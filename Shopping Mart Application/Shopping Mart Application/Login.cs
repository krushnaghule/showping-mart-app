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
    public partial class Login : Form
    {
        public static string username = "";
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from signup1 where name = @user and password = @pass";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", usernametextBox.Text);
            cmd.Parameters.AddWithValue("@pass", passwordtextBox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Successfully!! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = usernametextBox.Text;
                this.Hide();
                Form1 MainForm = new Form1();
                MainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed!! ", "failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch(check)
            {
                case true:
                    passwordtextBox.UseSystemPasswordChar = true;
                    break;

                default :
                    {
                        passwordtextBox.UseSystemPasswordChar = false;
                        break;
                    }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SignUp su = new SignUp();
            this.Hide();
            su.ShowDialog();
        }
    }
}
