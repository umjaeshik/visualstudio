using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintest02
{
    public partial class findForm : Form
    {
        public findForm(int op)
        {
            InitializeComponent();
            this.Text = " 찾기 / 바꾸기";
            if(op == 0)
            {
               button_replace.Visible = false;
               textBox_replace.Visible = false;
               label_replace.Visible=false;
            }
        }
    }
}
