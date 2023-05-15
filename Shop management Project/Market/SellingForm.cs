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
using System.Drawing.Printing;

namespace Market
{
    
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        public SellingForm(String user)
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Billing_Product values(@Date, @ID, @BillNo, @ProductName, @Quantity, @Price)", con);
            cmd.Parameters.AddWithValue("@Date", (dateTimeBilling.Text));
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("@BillNo", (textBoxBillNo.Text));
            cmd.Parameters.AddWithValue("@ProductName", (textBoxProductName.Text));
            cmd.Parameters.AddWithValue("@Quantity", (textBoxQuantity.Text));
            cmd.Parameters.AddWithValue("@Price", (textBoxPrice.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Added to Cart.");
        }
     

        private void button5_Click(object sender, EventArgs e)
        {
            ProductForm ps = new ProductForm("ProductForm");
            ps.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 sf = new Form1();
            sf.Show();
            this.Hide();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from products", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewRefresh.DataSource = dt;
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Billing_Product where ID='"+ textBoxID.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView_Cart.DataSource = dt;
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //e.Graphics.DrawString("INVENTORY SYSTEM ", new Font("Arial", 201 FontStyle.Bold))
        }
    }
}
