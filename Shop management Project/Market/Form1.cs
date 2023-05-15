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

namespace Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");


        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Username, user_Password;
            Username = textBox2.Text;
            user_Password = textBox3.Text;
            try
            {
                String query = "SELECT * FROM dbo.table_1 where Username = '" + textBox2.Text + "' AND Password = '" + textBox3.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    Username = textBox2.Text;
                    user_Password = textBox3.Text;
                    SellingForm se = new SellingForm();
                    se.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    textBox2.Text.Clone();

                    textBox3.Text.Clone();

                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
