using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace КП_БД
{
    public partial class Search : Form
    {
        const string ConnectionString = @"Server=localhost; Initial Catalog = DataDB; Integrated Security = True";
        DataSet dataSet = new DataSet();
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pname = textBox1.Text;
            string psurname = textBox2.Text;
            string chname = comboBox1.SelectedValue.ToString();
            string zname = comboBox2.SelectedValue.ToString();

            SqlDataAdapter dataAdapter;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                dataAdapter = new SqlDataAdapter("select pid 'ID', pname 'Name', psurname 'Surname', chname 'Chertog', hallno 'Hall', zname 'Zodiac', lifenumberno 'Life Number', " +
                                            "guardnumberno 'Guard Number', pyear 'Year', pmonth 'Month', pday 'day', phour 'Hour', pmin 'Min' from person, chertog, zodiak " +
                                            " where (chertog.chertogno = person.chertogno and zodiak.zodiakno = person.zodiakno)" +
                                            $" and (pname = '{pname}' or psurname = '{psurname}' or chname = '{chname}' or zname = '{zname}')", ConnectionString);
            }
            else if (checkBox1.Checked)
            {
                dataAdapter = new SqlDataAdapter("select pid 'ID', pname 'Name', psurname 'Surname', chname 'Chertog', hallno 'Hall', zname 'Zodiac', lifenumberno 'Life Number', " +
                                                "guardnumberno 'Guard Number', pyear 'Year', pmonth 'Month', pday 'day', phour 'Hour', pmin 'Min' from person, chertog, zodiak " +
                                                " where (chertog.chertogno = person.chertogno and zodiak.zodiakno = person.zodiakno)" +
                                                $" and (pname = '{pname}' or psurname = '{psurname}' or chname = '{chname}')", ConnectionString);
            }
            else if (checkBox2.Checked)
            {
                dataAdapter = new SqlDataAdapter("select pid 'ID', pname 'Name', psurname 'Surname', chname 'Chertog', hallno 'Hall', zname 'Zodiac', lifenumberno 'Life Number', " +
                                                "guardnumberno 'Guard Number', pyear 'Year', pmonth 'Month', pday 'day', phour 'Hour', pmin 'Min' from person, chertog, zodiak " +
                                                " where (chertog.chertogno = person.chertogno and zodiak.zodiakno = person.zodiakno)" +
                                                 $" and (pname = '{pname}' or psurname = '{psurname}' or zname = '{zname}')", ConnectionString);
            }
            else
            {
                dataAdapter = new SqlDataAdapter("select pid 'ID', pname 'Name', psurname 'Surname', chname 'Chertog', hallno 'Hall', zname 'Zodiac', lifenumberno 'Life Number', " +
                                                "guardnumberno 'Guard Number', pyear 'Year', pmonth 'Month', pday 'day', phour 'Hour', pmin 'Min' from person, chertog, zodiak " +
                                                " where (chertog.chertogno = person.chertogno and zodiak.zodiakno = person.zodiakno)" +
                                                $" and (pname = '{pname}' or psurname = '{psurname}')", ConnectionString);
            }
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDBDataSet.ZODIAK' table. You can move, or remove it, as needed.
            this.zODIAKTableAdapter.Fill(this.dataDBDataSet.ZODIAK);
            // TODO: This line of code loads data into the 'dataDBDataSet.CHERTOG' table. You can move, or remove it, as needed.
            this.cHERTOGTableAdapter.Fill(this.dataDBDataSet.CHERTOG);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            PdfPCell cell = new PdfPCell(new Phrase($"The required list of users ({DateTime.Now})", font1));
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
