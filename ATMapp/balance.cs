using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMapp
{


    public partial class balance : Form
    {
        private string text;
        private int len = 0;
        public balance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ATMapp\ATMapp\DATABASEatm\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;");
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum = '"+AccNumberlbl.Text+"' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = dt.Rows[0][0].ToString() + " $";
            Con.Close();
        }
        private void balance_Load(object sender, EventArgs e)
        {
            text = lbltext.Text;
            lbltext.Text = "";
            timer1.Start();
            AccNumberlbl.Text = HOME.AccNumber;
            getbalance();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
