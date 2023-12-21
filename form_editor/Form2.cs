using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace form_editor
{
    
    public partial class Form2 : Form
    {
        Form1 main = null;
        public Form2(Form1 main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string str;
            str = textBox_find.Text;
            
            int p = main.textBox1.Text.IndexOf(str);
            main.textBox1.Select(p, str.Length);
            main.ShowDialog();
           
        }
        
    }
}
