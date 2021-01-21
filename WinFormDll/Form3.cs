using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Connection;

namespace Test
{
    public partial class Form3 : Form
    {
        Block myblock = new Block();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.ToString().ToLower() == "ok")
            {
                this.textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myblock.BlockTime = Convert.ToDateTime(this.dateTimePicker1.Text).ToString("yyyy-MM-dd hh:mm:ss");
            myblock.BlockBgSound = this.textBox1.Text;
            MessageBox.Show("设定成功");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myblock.IsPlay() == true)
            {
                axWindowsMediaPlayer1.URL = myblock.BlockBgSound;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
