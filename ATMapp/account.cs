using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace ATMapp
{
    public partial class account : Form
    {
        private string text;
        private int len = 0;
        public account()
        {
            InitializeComponent();
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

        private void account_Load(object sender, EventArgs e)
        {
            text = lbltext.Text;
            lbltext.Text = "";
            timer1.Start();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ATMapp\ATMapp\DATABASEatm\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;");
        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNametb.Text == "" || AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccNumTb.Text + "', '" + AccNametb.Text + "', '" + FanameTb.Text + "', '" + PhoneTb.Text + "', '" + Addresstb.Text + "', '" + educationcb.SelectedItem.ToString() + "', " + pintb.Text + ", "+ bal +")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!");
                    Con.Close();
                    login log = new login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FanameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
