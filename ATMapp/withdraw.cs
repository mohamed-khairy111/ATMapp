using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMapp
{
    public partial class withdraw : Form
    {
        private string text;
        private int len = 0;
        public withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ATMapp\ATMapp\DATABASEatm\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;");
        string Acc = login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum = '" + Acc + "' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance " + dt.Rows[0][0].ToString() + " $";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            string TrType = "WithDraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', '" + wdamtTb.Text + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully!");
                Con.Close();
                //login log = new login();
                //log.Show();
                //this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void withdraw_Load(object sender, EventArgs e)
        {
            text = lbltext.Text;
            lbltext.Text = "";
            timer1.Start();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int newbalace;
        private void button2_Click(object sender, EventArgs e)
        {
            if (wdamtTb.Text == "")
            {
                MessageBox.Show("Missing Imformation!");
            }
            else if (Convert.ToInt32(wdamtTb.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if (Convert.ToInt32(wdamtTb.Text) > bal)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                try
                {
                    newbalace = bal - Convert.ToInt32(wdamtTb.Text);
                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance = " + newbalace + " where Accnum = '" + Acc + "' ";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Withdraw");
                        Con.Close();
                        addtransaction();
                        HOME home = new HOME();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME home = new HOME();
            home.Show();
        }
    }
}
