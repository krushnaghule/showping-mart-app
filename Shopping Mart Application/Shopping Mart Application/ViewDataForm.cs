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
    public partial class ViewDataForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public ViewDataForm()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            AddItemForm adf = new AddItemForm();
            adf.ShowDialog();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            EditItemForm adf = new EditItemForm();
            adf.ShowDialog();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            EditItemForm adf = new EditItemForm();
            adf.ShowDialog();
        }

        private void ViewDataForm_Activated(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
