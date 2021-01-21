using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Connection;

namespace Test.LoginForm
{
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        internal static string GetMD5(string input)
        {
            string cl = input;
            string pwd = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 

                pwd = pwd + s[i].ToString("X");

            }
            return pwd;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void Adduser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DataConntion.Camcon();
            // MySqlConnection Camcon = new MySqlConnection();
           // conn.ConnectionString = conn;
            try
            {
                conn.Open();
                string sql = "insert into User_tab(UserID,Password,UserName,UserUnit,Phone) VALUES ('" + Convert.ToString(textBox1.Text) + "','" + Convert.ToString(textBox2.Text) + "','" + Convert.ToString(txtUser.Text) + "','" + Convert.ToString(textBox3.Text) + "','" + Convert.ToString(textBox4.Text) + "' )";
                MySqlDataAdapter mda = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "table1");
                MessageBox.Show("注册成功");
                //this.dataGridView1.DataSource = ds.Tables["table1"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"用户以存在");
            }
        }
    }
}
