using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace wintest04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void AddTextCB(string text, int n);
        void AddText(string text, int op = 0)
        {
            if (textBox_terminal.InvokeRequired)
            {
                AddTextCB cb = new AddTextCB(AddText);
                object[] obj = { text, op };
                Invoke(cb, obj);
            }
            else
            {
                textBox_terminal.Text += text;
                if (op == 0)
                {
                    textBox_terminal.Text += "\r\n";
                }
            }
            
        }
        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config con = new config();
            con.ShowDialog();
            //통신설정
            //환경설정 : 배경색, 문자크기(font), 
            serialPort1.Parity = (Parity)con.comboBox_Parity.SelectedIndex; // 0
            serialPort1.DataBits = int.Parse(con.comboBox_Data.Text);
            serialPort1.StopBits = (StopBits)con.comboBox_Stop.SelectedIndex; // 1
            serialPort1.BaudRate = int.Parse(con.comboBox_Baud.Text);
            serialPort1.PortName = con.comboBox_Com.Text;
            //serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity),parity,true);

            string info_con = $"{serialPort1.PortName} : {serialPort1.BaudRate} {serialPort1.Parity} {serialPort1.DataBits} {serialPort1.StopBits}";
            AddText(info_con);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                AddText($"{serialPort1.PortName} Port closed");
            }
            
            serialPort1.Open();
            AddText($"{serialPort1.PortName} Port Open sucess!");

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            AddText(serialPort1.ReadExisting(),1);
        }
    }
}
