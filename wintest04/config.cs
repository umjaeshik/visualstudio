using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintest04
{
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
            string[] Port = System.IO.Ports.SerialPort.GetPortNames();
            comboBox_Com.Items.Clear();
            comboBox_Com.Items.AddRange(Port);

        }

        
    }
}
