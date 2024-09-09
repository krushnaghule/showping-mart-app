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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shopping_Mart_Application
{
    public partial class AddItemForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public AddItemForm()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into items_tbl1 values(@name,@price,@discount)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", nametextbox.Text);
            cmd.Parameters.AddWithValue("@price", pricetextbox.Text);
            cmd.Parameters.AddWithValue("@discount", discounttextbox.Text);
            
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Item Added Successfully!!", " success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nametextbox.Clear();
                pricetextbox.Clear();
                discounttextbox.Clear();
                nametextbox.Focus();
            }
            else
            {
                MessageBox.Show("Item is Not Added ", " Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }
    }
}
