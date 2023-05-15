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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(String user)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into products values(@ProductID, @ProductName, @Price, @Quantity, @Catagory)", con);
            cmd.Parameters.AddWithValue("@ProductID", (textBoxProductID.Text));
            cmd.Parameters.AddWithValue("@ProductName", (textBoxProductName.Text));
            cmd.Parameters.AddWithValue("@Price", (textBoxPrice.Text));
            cmd.Parameters.AddWithValue("@Quantity", (textBoxQuantity.Text));
            cmd.Parameters.AddWithValue("@Catagory", (textBoxCatagory.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Added Products.");
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from products", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewProduct.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  Products set ProductName=@ProductName, Price=@Price, Quantity=@Quantity, Catagory=@Catagory where ProductID=@ProductID", con);
            cmd.Parameters.AddWithValue("@ProductID", (textBoxProductID.Text));
            cmd.Parameters.AddWithValue("@ProductName", (textBoxProductName.Text));
            cmd.Parameters.AddWithValue("@Price", (textBoxPrice.Text));
            cmd.Parameters.AddWithValue("@Quantity", (textBoxQuantity.Text));
            cmd.Parameters.AddWithValue("@Catagory", (textBoxCatagory.Text)); 

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Product.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Products where ProductID=@ProductID", con);
            cmd.Parameters.AddWithValue("@ProductID",(textBoxProductID.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted Product.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sellerform sf = new Sellerform ();
            sf.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            sf.Show();
            this.Hide();
        }
    }
}
