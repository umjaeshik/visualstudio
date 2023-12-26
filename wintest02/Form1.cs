using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintest02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog(this);
            if (r == DialogResult.OK)
            {
                string file_name = openFileDialog1.FileName;
                FileStream fi = new FileStream(file_name,FileMode.Open);
                StreamReader sr = new StreamReader(fi);
                textBox1.Text = sr.ReadToEnd();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                findForm frm = new findForm(0);
                frm.Show();
                string str = frm.textBox_find.Text;
                int s = textBox1.Text.IndexOf(str);
                textBox1.Select(s, str.Length);


                // strncmp(textBox1.Text, str, str.Length;
                //frm.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                findForm frm = new findForm(1);
                frm.ShowDialog();
                string str = frm.textBox_find.Text;
                string str1 = frm.textBox_replace.Text;
                int s = textBox1.Text.IndexOf(str);
                textBox1.Text.Replace(str, str1);
                //textBox1.Select(s, str.Length);

                // strncmp(textBox1.Text, str, str.Length;
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

