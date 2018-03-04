using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string s = "Chúc mừng năm mới - Happy new year! ";

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button3.Visible = true;
            this.timer1.Interval = 500;
            this.timer1.Enabled = true;
        }

        int i = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text += s[i - 1];
            i++;
            if (i > s.Length)
            {
                this.timer1.Enabled = false;
                this.button1.Visible = true;
                this.button3.Visible = false;
                this.label1.Text = null;
                i = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.button1.Visible = true;
            this.button3.Visible = false;
        }
    }
}
