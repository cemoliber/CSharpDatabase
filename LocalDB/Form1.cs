using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genderCheckBox_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.costomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'modelDataSet.Costomers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.costomersTableAdapter.Fill(this.modelDataSet.Costomers);

        }

        private void costomersBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.costomersBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.modelDataSet1);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'modelDataSet1.Costomers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.costomersTableAdapter1.Fill(this.modelDataSet1.Costomers);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phoneTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void genderCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(genderCheckBox1.CheckState == CheckState.Checked)
            {
                genderCheckBox1.Text = "Male";
            }else if(genderCheckBox1.CheckState == CheckState.Unchecked)
            {
                genderCheckBox1.Text = "Female";
            }
            else
            {
                genderCheckBox1.Text = "?";
            }
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
