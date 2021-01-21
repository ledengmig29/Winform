using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Connection;

namespace Test.LoginForm
{
    public partial class Login : Form
    {
        public Login()
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

        private void button6_Click(object sender, EventArgs e)
        {
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Adduser ad = new Adduser();
            ad.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.TabIndex = 0;  //直接textBox1.Focus();不管用
            txtUser.Focus();
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出登录吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)

            {

                Application.Exit();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")

            {

                MessageBox.Show("请输入用户名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else

            {

                if (txtPass.Text == "")

                {
                    MessageBox.Show("请输入密码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else

                {

                    MySqlConnection conn = DataConntion.Camcon();

                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("select count(*) from User_tab where UserID='" + txtUser.Text + "'and Password='" + txtPass.Text + "'", conn);

                    int num = Convert.ToInt32(cmd.ExecuteScalar());

                    if (num > 0)

                    {

                        conn.Close();

                        MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;

                    }

                    else

                    {

                        MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                 

                }

            }
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {

                txtPass.Focus();

            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {

                btnLogin_Click(sender, e);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Adduser ad = new Adduser();
            ad.ShowDialog();
        }
    }
}
