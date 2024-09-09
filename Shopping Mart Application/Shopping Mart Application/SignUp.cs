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
    public partial class SignUp : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into signup1 values(@name,@surname,@gender,@age,@address,@email,@pass)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", nametextbox.Text);
            cmd.Parameters.AddWithValue("@surname", surnametextbox.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Text);
            cmd.Parameters.AddWithValue("@address", addresstextbox.Text);
            cmd.Parameters.AddWithValue("@email", emailtextbox.Text);
            cmd.Parameters.AddWithValue("pass", passwordtextbox.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Registered Successfully!!", " success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Username is: " + nametextbox.Text + "\n\n" + "password is: " + passwordtextbox.Text, " success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Login loginform = new Login();
                loginform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Registered Failed!!", " Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }
    }
}
