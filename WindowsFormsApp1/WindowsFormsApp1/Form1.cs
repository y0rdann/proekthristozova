using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3load_Click(object sender, EventArgs e)
        {
            this.bazaTableAdapter.Fill(this.databaseDataSet.baza);
            databaseDataSet.baza.AddbazaRow(textBox1.Text, textBox2.Text, textBox3.Text);
            this.bazaTableAdapter.Fill(this.databaseDataSet.baza);
        }

        private void button4delete_Click(object sender, EventArgs e)
        {
            bazaBindingSource.RemoveCurrent();
        }

        private void button5add_Click(object sender, EventArgs e)
        {
            bazaBindingSource.AddNew();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.baza' table. You can move, or remove it, as needed.
          //  this.bazaTableAdapter.Fill(this.databaseDataSet.baza);

        }

        private void button6_save_Click(object sender, EventArgs e)
        {
            bazaBindingSource.MoveNext();
            bazaBindingSource.EndEdit();
            bazaTableAdapter.Update(databaseDataSet.baza);
            MessageBox.Show("Saved");
        }
    }
}
