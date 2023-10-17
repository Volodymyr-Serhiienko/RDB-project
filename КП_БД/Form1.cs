using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace КП_БД
{
    public partial class Form1 : Form
    {
        const string ConnectionString = @"Server=localhost; Initial Catalog = DataDB; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDBDataSet.LIFENUMBER' table. You can move, or remove it, as needed.
            this.lIFENUMBERTableAdapter.Fill(this.dataDBDataSet.LIFENUMBER);
            // TODO: This line of code loads data into the 'dataDBDataSet.HALL' table. You can move, or remove it, as needed.
            this.hALLTableAdapter.Fill(this.dataDBDataSet.HALL);
            // TODO: This line of code loads data into the 'dataDBDataSet.ZODIAK' table. You can move, or remove it, as needed.
            this.zODIAKTableAdapter.Fill(this.dataDBDataSet.ZODIAK);
            // TODO: This line of code loads data into the 'dataDBDataSet.GUARDNUMBER' table. You can move, or remove it, as needed.
            this.gUARDNUMBERTableAdapter.Fill(this.dataDBDataSet.GUARDNUMBER);
            // TODO: This line of code loads data into the 'dataDBDataSet.CHERTOG' table. You can move, or remove it, as needed.
            this.cHERTOGTableAdapter.Fill(this.dataDBDataSet.CHERTOG);
            // TODO: This line of code loads data into the 'dataDBDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.dataDBDataSet.PERSON);
            dataGridView2.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pERSONTableAdapter.Update(dataDBDataSet);
            cHERTOGTableAdapter.Update(dataDBDataSet);
            hALLTableAdapter.Update(dataDBDataSet);
            zODIAKTableAdapter.Update(dataDBDataSet);
            lIFENUMBERTableAdapter.Update(dataDBDataSet);
            gUARDNUMBERTableAdapter.Update(dataDBDataSet);
        }

        private void cHERTOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = cHERTOGBindingSource;
            dataGridView2.DataSource = cHERTOGBindingSource;
            label2.Text = "Chertog";
        }

        private void gUARDNUMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = gUARDNUMBERBindingSource;
            dataGridView2.DataSource = gUARDNUMBERBindingSource;
            label2.Text = "GuardNumber";
        }

        private void zODIAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = zODIAKBindingSource;
            dataGridView2.DataSource = zODIAKBindingSource;
            label2.Text = "Zodiak";
        }

        private void hALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = hALLBindingSource;
            dataGridView2.DataSource = hALLBindingSource;
            label2.Text = "Hall";
        }

        private void lIFENUMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = lIFENUMBERBindingSource;
            dataGridView2.DataSource = lIFENUMBERBindingSource;
            label2.Text = "LifeNumber";
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource.EndEdit();
            pERSONTableAdapter.Update(dataDBDataSet);
            switch (label2.Text)
            {
                case "Chertog": cHERTOGTableAdapter.Update(dataDBDataSet); break;
                case "Zodiak": zODIAKTableAdapter.Update(dataDBDataSet); break;
                case "Hall": hALLTableAdapter.Update(dataDBDataSet); break;
                case "LifeNumber": lIFENUMBERTableAdapter.Update(dataDBDataSet); break;
                case "GuardNumber": gUARDNUMBERTableAdapter.Update(dataDBDataSet); break;
            }
            this.pERSONTableAdapter.Fill(this.dataDBDataSet.PERSON);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource.CancelEdit();
            this.cHERTOGTableAdapter.Fill(this.dataDBDataSet.CHERTOG);
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pERSONTableAdapter.Fill(this.dataDBDataSet.PERSON);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (label2.Text)
            {
                case "Chertog": this.cHERTOGTableAdapter.Fill(this.dataDBDataSet.CHERTOG); break;
                case "Zodiak": this.zODIAKTableAdapter.Fill(this.dataDBDataSet.ZODIAK); break;
                case "Hall": this.hALLTableAdapter.Fill(this.dataDBDataSet.HALL); break;
                case "LifeNumber": this.lIFENUMBERTableAdapter.Fill(this.dataDBDataSet.LIFENUMBER); break;
                case "GuardNumber": this.gUARDNUMBERTableAdapter.Fill(this.dataDBDataSet.GUARDNUMBER); break;
            }
        }

        private void chertogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ch = new ViewChertog();
            ch.ShowDialog();
            pERSONTableAdapter.Fill(dataDBDataSet.PERSON);
            cHERTOGTableAdapter.Fill(dataDBDataSet.CHERTOG);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new Add_Person();
            edt.ShowDialog();
            pERSONTableAdapter.Fill(dataDBDataSet.PERSON);
            dataDBDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var st = new DataDBDataSet.PERSONDataTable();
            pERSONTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new Add_Person(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(),
                Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), Convert.ToInt32(row[6]), Convert.ToInt32(row[7]),
                Convert.ToInt32(row[8]), Convert.ToInt32(row[9]), Convert.ToInt32(row[10]), Convert.ToInt32(row[11]), Convert.ToInt32(row[12]));
            edt.ShowDialog();
            pERSONTableAdapter.Fill(dataDBDataSet.PERSON);
            dataDBDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pERSONTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            pERSONTableAdapter.Fill(dataDBDataSet.PERSON);
            dataDBDataSet.AcceptChanges();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new Search();
            edt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter;
            dataAdapter = new SqlDataAdapter("select pid, pname 'Name', psurname 'Surname', chname 'Chertog', hallno 'Hall', zname 'Zodiac', lifenumberno 'Life Number', " +
                                            "guardnumberno 'Guard Number', pyear 'Year', pmonth 'Month', pday 'day', phour 'Hour', pmin 'Min' from person, chertog, zodiak " +
                                            "where person.chertogno = chertog.chertogno and person.zodiakno = zodiak.zodiakno", ConnectionString);
            dataAdapter.Fill(dataSet);
            
            saveFileDialog1.Filter = "PDF files(*.pdf)|*.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;

            Document doc = new Document(PageSize.A4, 0f, 0f, 20f, 0f);
            PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font1 = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 7, iTextSharp.text.Font.NORMAL); // iTextSharp.text.Font.DEFAULTSIZE

            //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
            PdfPTable table = new PdfPTable(12); // dataSet.Tables[0].Columns.Count
            //Добавим в таблицу общий заголовок
            PdfPCell cell = new PdfPCell(new Phrase($"The list of users ({DateTime.Now})", font1));
            cell.Colspan = 12;
            cell.HorizontalAlignment = 1;
            //Убираем границу первой ячейки, чтобы балы как заголовок
            cell.Border = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(" ", font));
            cell.Colspan = 12;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            //Сначала добавляем заголовки таблицы
            for (int j = 1; j < 13; j++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(dataSet.Tables[0].Columns[j].ColumnName, font)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
            }

            //Добавляем все остальные ячейки
            for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
            {
                for (int k = 1; k < 13; k++)
                {
                    table.AddCell(new Phrase(dataSet.Tables[0].Rows[j][k].ToString(), font));
                }
            }

            cell = new PdfPCell(new Phrase(" ", font));
            cell.Colspan = 12;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Executive Director _________", font));
            cell.Colspan = 12;
            cell.HorizontalAlignment = 2;
            cell.Border = 0;
            table.AddCell(cell);

            //Добавляем таблицу в документ
            doc.Add(table);
            //Закрываем документ
            doc.Close();
            MessageBox.Show("Pdf-document is saved!");
        }
    }
}
