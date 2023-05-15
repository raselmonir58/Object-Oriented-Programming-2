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
    public partial class Sellerform : Form
    {
        public Sellerform()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into manage_seller values(@ID, @Name, @Age, @Phone)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", (textBoxName.Text));
            cmd.Parameters.AddWithValue("@Age", (textBoxAge.Text));
            cmd.Parameters.AddWithValue("@Phone", (textBoxPhone.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Added.");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  manage_seller set Name=@Name, Age=@Age, Phone=@Phone where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", (textBoxName.Text));
            cmd.Parameters.AddWithValue("@Age", (textBoxAge.Text));
            cmd.Parameters.AddWithValue("@Phone", (textBoxPhone.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated.");

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete manage_seller where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted.");
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73GFDN5\SQLEXPRESS;Initial Catalog=DemoDb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from manage_seller", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView_ManageSeller.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm sf = new ProductForm();
            sf.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 sf = new Form1();
            sf.Show();
            this.Hide();
        }
    }
}
