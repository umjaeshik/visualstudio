using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        List<string> colName = new List<string>();
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                
                sqlCon.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlCon.Open();
                sqlCommand.Connection = sqlCon;
                SLabel1.Text = "Database connected";
            }
        }

        private List<string> RunSql(string sql)
        {
            List<string> sarr = new List<string>();
            colName.Clear();
            sarr.Clear();
            sqlCommand.CommandText = sql;
            if (sql.Trim().ToLower().Substring(0, 6) == "select") 
            {
                
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                
                
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    colName.Add(sqlDataReader.GetName(i).ToString());

                for (int i = 0; sqlDataReader.Read(); i++)
                {
                    string str = "";

                    for (int j = 0; j < sqlDataReader.FieldCount; j++)
                        str += sqlDataReader.GetValue(j).ToString()+",";

                    sarr.Add(str);
                }
                viewSql(sarr);
                sqlDataReader.Close();
                
            }
            else
            {
                sqlCommand.ExecuteNonQuery();                
            }

            
            return sarr;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string sql = "select * from student";
            sqlCommand.CommandText = sql;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            for(int i=0; sqlDataReader.Read(); i++)
            {
                for(int j=0; j<sqlDataReader.FieldCount;j++)
                    textBox1.Text += sqlDataReader.GetValue(j).ToString();

                textBox1.Text += "\r\n";
            }
            sqlDataReader.Close();
        }
        private void viewSql(List<string> sarr)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (int i = 0; i < colName.Count; i++)
            {
                dataGridView1.Columns.Add(colName[i], colName[i]);
            }

            for (int i = 0; i < sarr.Count; i++)
            {
                int rindex = dataGridView1.Rows.Add();
                for (int j = 0; j < colName.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = sarr[i].Split(',')[j];
                }
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RunSql("select * from student");

            



        }
    }
}
