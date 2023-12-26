using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class frmTest1 : Form
    {
        public frmTest1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            flag = flag % 4;
            switch(flag)
            {
                case 0:
                    textBox1.Text = $"{flag+1}";
                    break;
                case 1:
                    textBox2.Text = $"{flag + 1}";
                    break;
                case 2:
                    textBox3.Text = $"{flag + 1}";
                    break;
                case 3:
                    textBox4.Text = $"{flag + 1}";
                    break;
                
            }
            flag++;
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                comboBox1.Enabled = true;
            else comboBox1.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void upperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.ToUpper();

        }

        private void lowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.ToLower();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
            
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox4.Text = openFileDialog1.FileName;


            

        }
    }
}
