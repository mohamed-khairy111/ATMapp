using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMapp
{
    public partial class HOME : Form
    {
        private string text;
        private string text2;
        private int len = 0;
        private int len2 = 0;
        public HOME()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lblText.Text = lblText.Text + text.ElementAt(len);
                len++;
            }
            else
                timer1.Stop();
        }

        public static string AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
            text = lblText.Text;
            lblText.Text = "";
            text2 = label2.Text;
            label2.Text = "";
            timer1.Start();
            timer2.Start();
            AccNumber = login.AccNumber;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len2 < text2.Length)
            {
                label2.Text = label2.Text + text2.ElementAt(len2);
                len2++;
            }
            else
                timer2.Stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            balance bal = new balance();
            this.Hide();
            bal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposite depo = new Deposite();
            depo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            withdraw wd = new withdraw();
            wd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fastcash Fcash = new fastcash();
            Fcash.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ministatement mini = new ministatement();
            mini.Show();
            this.Hide();
        }
    }
}
