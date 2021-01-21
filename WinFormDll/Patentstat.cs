using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.WinFormDll
{
    public partial class Patentstat : Form
    {
        public Patentstat()
        {
            InitializeComponent();
        }
        private String connStr = "server=;user id = root;password = ;database = feizi;Charset=utf8";
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconn = new MySqlConnection();
            DBconn.ConnectionString = connStr;
            try
            {
                DBconn.Open();
                string sql = "insert into ";
                MySqlDataAdapter mda = new MySqlDataAdapter(sql, DBconn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "table1");
                //this.dataGridView1.DataSource = ds.Tables["table1"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconn = new MySqlConnection();
            DBconn.ConnectionString = connStr;
            try
            {
                DBconn.Open();//要加一个textbox 匹对数据库ID栏位 目前没有做
                string sql = "insert into annual_fee (id,annual_fee_two,completion_time,overdeu_fine,Time_span,annual_fee_three,due_date,remark) values ( '" + Convert.ToString(textBox30.Text) + "','" + Convert.ToString(textBox29.Text) + "','" + Convert.ToString(textBox28.Text) +"','" + Convert.ToString(textBox27.Text) + "','" + Convert.ToString(textBox26.Text) + "','" + Convert.ToString(textBox25.Text) + "','" + Convert.ToString(textBox23.Text) +"')";
                MySqlDataAdapter mda = new MySqlDataAdapter(sql, DBconn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "table1");
                //this.dataGridView1.DataSource = ds.Tables["table1"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
