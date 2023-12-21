using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr =openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filename = openFileDialog1.SafeFileName;
                string filefullname = openFileDialog1.FileName;
                string filepath = filefullname.Replace(filename, "");

                label1.Text = "filename : " + filename;
                label2.Text = "fullname : " + filefullname;
                label3.Text = "filepath : " + filepath;
                StreamReader sr = new StreamReader(filefullname);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();


            }


        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Form2 fr = new Form2(this);
            DialogResult dr = fr.ShowDialog();

        }
    }
}
