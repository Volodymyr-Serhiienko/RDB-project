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
    public partial class ViewChertog : Form
    {
        public ViewChertog()
        {
            InitializeComponent();
        }

        private void cHERTOGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHERTOGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDBDataSet);

        }

        private void RSForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDBDataSet.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.dataDBDataSet.PERSON);
            // TODO: This line of code loads data into the 'dataDBDataSet.CHERTOG' table. You can move, or remove it, as needed.
            this.cHERTOGTableAdapter.Fill(this.dataDBDataSet.CHERTOG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to confirm changes?","Data change", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try 
                { 
                    cHERTOGBindingSource.EndEdit();
                    cHERTOGTableAdapter.Update(dataDBDataSet);
                    pERSONTableAdapter.Update(dataDBDataSet);
                }
                catch
                {
                    MessageBox.Show("An Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
