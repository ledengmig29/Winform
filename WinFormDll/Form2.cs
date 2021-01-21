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

namespace Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private Size beforeResizeSize = Size.Empty;
        private Size endResizeSize = Size.Empty;
        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
            beforeResizeSize = this.Size;
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            //窗口resize之后的大小
            Size endResizeSize = this.Size;
            UpdateControlSizes(beforeResizeSize, endResizeSize);
        }
        const int WM_SYSCOMMAND = 0x112;
        const int SC_CLOSE = 0xF060;
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_NOMAL = 0xF120;
        const int SC_MAXIMIZE2 = 0xF032;
        const int SC_NOMAL2 = 0xF122;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam.ToInt32() == SC_MINIMIZE) //是否点击最小化
                {
                    //.....................
                }
                if (m.WParam.ToInt32() == SC_MAXIMIZE || m.WParam.ToInt32() == SC_MAXIMIZE2) //是否点击最大化
                {
                    isJustClickedMaximizebox = true;
                    beforeResizeSize = this.Size;
                }
                if (m.WParam.ToInt32() == SC_NOMAL || m.WParam.ToInt32() == SC_NOMAL2) //是否点击还原
                {
                    isJustClickedNomalbox = true;
                }
                if (m.WParam.ToInt32() == SC_CLOSE) //是否点击关闭
                {  //.....................
                }
            }
            base.WndProc(ref m);
        }



        Boolean isJustClickedMaximizebox = false;
        Boolean isJustClickedNomalbox = false;
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (isJustClickedMaximizebox)
            {
                endResizeSize = this.Size;
                UpdateControlSizes(beforeResizeSize, endResizeSize);
                isJustClickedMaximizebox = false;
            }
            if (isJustClickedNomalbox)
            {
                UpdateControlSizes(endResizeSize, beforeResizeSize);
                isJustClickedNomalbox = false;
            }
        }



        private void UpdateControlSizes(Size beforeResizeSize, Size endResizeSize)
        {
            //获得变化比例
            float percentWidth = (float)endResizeSize.Width / beforeResizeSize.Width;
            float percentHeight = (float)endResizeSize.Height / beforeResizeSize.Height;
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    continue;
                }
                //按比例改变控件大小
                control.Width = (int)(control.Width * percentWidth);
                //为了不使控件之间覆盖 位置也要按比例变化
                control.Left = (int)(control.Left * percentWidth);
            }
        }
        private String connStr = "server=;user id = root;password = .;database = feizi;Charset=utf8";
        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection DBconn = new MySqlConnection();
            DBconn.ConnectionString = connStr;
            try
            {
                DBconn.Open();
                string starttime = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string endtime = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string sql = string.Format("select sales'业务员',client_name'客户姓名',apply_num'申请号',apply_name'申请人',patent_name'专利名',patent_type'专利类型',writer'撰写人',remark'备注',status_flow'状态流程点',status_timer'状态时间',audit_fee'实审费',By_the_time'受通时间',application_fee'申请费',whether_paid'是否缴纳',completion_time'完成时间' from patentStat_tab where status_timer > '" + starttime + "' and status_timer < '" + endtime + "' ");
                MySqlDataAdapter mda = new MySqlDataAdapter(sql, DBconn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "table1");
                this.dataGridView1.DataSource = ds.Tables["table1"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconn = new MySqlConnection();
            DBconn.ConnectionString = connStr;
            try
            {
                DBconn.Open();
               ///需要加一个textbox关联ID查询
                string sql = string.Format("");
                MySqlDataAdapter mda = new MySqlDataAdapter(sql, DBconn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "table1");
                this.dataGridView1.DataSource = ds.Tables["table1"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
