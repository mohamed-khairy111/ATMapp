using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMapp
{
    public partial class ChangePin : Form

    {
        private string text;
        private int len = 0;
        public ChangePin()
        {
            InitializeComponent();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {
            text = lbltext.Text;
            lbltext.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lbltext.Text = lbltext.Text + text.ElementAt(len);
                len++;
            }
            else
                timer1.Stop();
        }
    }
}
