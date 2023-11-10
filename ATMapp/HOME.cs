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

        private void HOME_Load(object sender, EventArgs e)
        {
            text = lblText.Text;
            lblText.Text = "";
            text2 = label2.Text;
            label2.Text = "";
            timer1.Start();
            timer2.Start();
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
    }
}
