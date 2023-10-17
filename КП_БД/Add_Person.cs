using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КП_БД
{
    public partial class Add_Person : Form
    {
        ///<summary>
        ///pid
        ///</summary>
        private readonly int pid;
        ///<summary>
        ///true - если запись модифицируется, false - если добавляется новая
        ///</summary>
        readonly bool edit;
        ///<summary>
        ///конструктор формы для создания новой записи
        ///</summary>
        public Add_Person()
        {
            InitializeComponent();
            gUARDNUMBERTableAdapter.Fill(dataDBDataSet.GUARDNUMBER);
            lIFENUMBERTableAdapter.Fill(dataDBDataSet.LIFENUMBER);
            zODIAKTableAdapter.Fill(dataDBDataSet.ZODIAK);
            hALLTableAdapter.Fill(dataDBDataSet.HALL);
            cHERTOGTableAdapter.Fill(dataDBDataSet.CHERTOG);
            edit = false;
        }
        ///<summary>
        ///конструктор формы для модификации уже существующей записи
        ///</summary>
        ///<param name = "pname">Pname</param>
        ///<param name = "psurname">Psurname</param>
        ///<param name = "chertogno">Chertogno</param>
        ///<param name = "hallno">Hallno</param>
        ///<param name = "zodiakno">Zodiakno</param>
        ///<param name = "lifenumberno">Lifenumberno</param>
        ///<param name = "guardnumberno">Guardnumberno</param>
        ///<param name = "pyear">Pyear</param>
        ///<param name = "pmonth">Pmonth</param>
        ///<param name = "pday">Pday</param>
        ///<param name = "phour">Phour</param>
        ///<param name = "pmin">Pmin</param>
        ///<param name = "pid">Pid</param>
        public Add_Person(int pid, string pname, string psurname, int chertogno, int hallno, int zodiakno, int lifenumberno, int guardnumberno, int pyear, int pmonth,
            int pday, int phour, int pmin)
            :this()
        {
            gUARDNUMBERTableAdapter.Fill(dataDBDataSet.GUARDNUMBER);
            lIFENUMBERTableAdapter.Fill(dataDBDataSet.LIFENUMBER);
            zODIAKTableAdapter.Fill(dataDBDataSet.ZODIAK);
            hALLTableAdapter.Fill(dataDBDataSet.HALL);
            cHERTOGTableAdapter.Fill(dataDBDataSet.CHERTOG);
            edit = true;
            this.pid = pid;
            textBox1.Text = pname;
            textBox2.Text = psurname;
            comboBox1.SelectedValue = chertogno;
            comboBox2.SelectedValue = hallno;
            comboBox5.SelectedValue = zodiakno;
            comboBox4.SelectedValue = lifenumberno;
            comboBox3.SelectedValue = guardnumberno;
            textBox3.Text = Convert.ToString(pyear);
            textBox4.Text = Convert.ToString(pmonth);
            textBox5.Text = Convert.ToString(pday);
            textBox6.Text = Convert.ToString(phour);
            textBox7.Text = Convert.ToString(pmin);
        }
        
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                personTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),
                    Convert.ToInt32(comboBox5.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue),
                    Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text),
                    Convert.ToInt32(textBox7.Text), pid);
            }
            else
            {
                personTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),
                    Convert.ToInt32(comboBox5.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue),
                    Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text),
                    Convert.ToInt32(textBox7.Text));
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
