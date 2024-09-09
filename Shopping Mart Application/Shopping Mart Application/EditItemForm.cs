using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Shopping_Mart_Application
{
    public partial class EditItemForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public EditItemForm()
        {
            InitializeComponent();
            BindGridView();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from items_tbl1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idtextbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametextbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pricetextbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            discounttextbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update items_tbl1 set item_name = @name, item_price = @price, item_discount = @discount";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", idtextbox.Text);
            cmd.Parameters.AddWithValue("@name", nametextbox.Text);
            cmd.Parameters.AddWithValue("@price", pricetextbox.Text);
            cmd.Parameters.AddWithValue("@discount", discounttextbox.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Item Updated Successfully!!", " success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                idtextbox.Clear();
                nametextbox.Clear();
                pricetextbox.Clear();
                discounttextbox.Clear();
                nametextbox.Focus();
            }
            else
            {
                MessageBox.Show("Item is Not Updated ", " Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from items_tbl1 where item_id = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", idtextbox.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Item Deleted Successfully!!", " success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                idtextbox.Clear();
                nametextbox.Clear();
                pricetextbox.Clear();
                discounttextbox.Clear();
                nametextbox.Focus();
            }
            else
            {
                MessageBox.Show("Item is Not Deleted ", " Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
