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
    public partial class Form1 : Form
    {
        int FinalCost = 0;
        int SrNo = 0;
        int tax = 0;
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            getinvoiceid();
            usertextbox.Text = Login.username;
            GetItems();
            dataGridView.ColumnCount = 8;
            dataGridView.Columns[0].Name = "SR NO";
            dataGridView.Columns[1].Name = "ITEM NAME";
            dataGridView.Columns[2].Name = "UNIT PRICE";
            dataGridView.Columns[3].Name = "DISCOUNT PER ITEM";
            dataGridView.Columns[4].Name = "QUANTITY";
            dataGridView.Columns[5].Name = "SUB TOTAL";
            dataGridView.Columns[6].Name = "TAX";
            dataGridView.Columns[7].Name = "TOTAL COST";
        }
        void GetItems()
        {
            selectitemcombox.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from items_tbl1";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string item_name  = dr.GetString(1);
                selectitemcombox.Items.Add(item_name);

            }
            selectitemcombox.Sorted = true;
            con.Close();
        }
        void getprice()
        {
            if(selectitemcombox.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "select item_price from items_tbl1 where item_name = @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", selectitemcombox.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["item_price"]);
                }
                unitpricetextbox.Text = price.ToString();
            }
            
        }

        void getdiscount()
        {
            if (selectitemcombox.SelectedItem == null)
            {

            }
            else
            {
                int discount = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "select item_discount from items_tbl1 where item_name = @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", selectitemcombox.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    discount = Convert.ToInt32(data.Rows[0]["item_discount"]);
                }
                discounttextbox.Text = discount.ToString();
            }
            
        }

        private void selectitemcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
            getdiscount();
            quantitytextbox.Enabled = true; 
        }


        private void quantitytextbox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(quantitytextbox.Text) == true)
            {

            }
            else
            {
                int price = Convert.ToInt32(unitpricetextbox.Text);
                int discount = Convert.ToInt32(discounttextbox.Text);
                int quantity = Convert.ToInt32(quantitytextbox.Text);

                int subTotal = price * quantity;
                subTotal = subTotal - (discount * quantity);
                subtotaltextBox.Text = subTotal.ToString();
            }
            
        }

        private void subtotaltextBox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(subtotaltextBox.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(subtotaltextBox.Text);
                if (subTotal >= 10000)
                {
                    tax = (int)(subTotal * 0.15);
                    taxtextBox.Text = tax.ToString();
                }
                else if (subTotal >= 6000)
                {
                    tax = (int)(subTotal * 0.10);
                    taxtextBox.Text = tax.ToString();
                }
                else if (subTotal >= 3000)
                {
                    tax = (int)(subTotal * 0.07);
                    taxtextBox.Text = tax.ToString();
                }
                else if (subTotal >= 1000)
                {
                    tax = (int)(subTotal * 0.05);
                    taxtextBox.Text = tax.ToString();
                }
                else
                {
                    tax = (int)(subTotal * 0.03);
                    taxtextBox.Text = tax.ToString();
                }
            }
        }
            

        private void taxtextBox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(taxtextBox.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(subtotaltextBox.Text);
                int tax = Convert.ToInt32(taxtextBox.Text);
                int totalCost = subTotal + tax;
                totalcosttextBox.Text = totalCost.ToString();
            }
            
        }

        void AddDataToGridView(string Sr_No, string item_name, string unit_price, string discount, string quantity, string sub_total, string tax, string total_cost)
        {
            string[] row = { Sr_No, item_name, unit_price, discount, quantity, sub_total, tax, total_cost};
            dataGridView.Rows.Add(row);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if(selectitemcombox.SelectedItem != null)
            {
                AddDataToGridView((++SrNo).ToString(), selectitemcombox.Text.ToString(), unitpricetextbox.Text, discounttextbox.Text, quantitytextbox.Text, subtotaltextBox.Text, taxtextBox.Text, totalcosttextBox.Text);
                ResetControls();
                CalculateFinalCost();
            }
            else
            {
                MessageBox.Show("please select an Item");
            }
           
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void ResetControls()
        {
            selectitemcombox.SelectedItem = null;
            unitpricetextbox.Clear();
            discounttextbox.Clear();
            quantitytextbox.Clear();
            subtotaltextBox.Clear();
            taxtextBox.Clear();
            totalcosttextBox.Clear();
            finalcosttextBox.Clear();
            amountpaittextbox.Clear();
            changetextbox.Clear();
            quantitytextbox.Enabled = false;

        }

        void CalculateFinalCost()
        {
            FinalCost = 0;
            for(int i = 0; i < dataGridView.Rows.Count; i++)
            {
                FinalCost = FinalCost + Convert.ToInt32(dataGridView.Rows[i].Cells[7].Value);
            }
            finalcosttextBox.Text = FinalCost.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(amountpaittextbox.Text) == true)
            {

            }
            else
            {
                int AmountPaid = Convert.ToInt32(amountpaittextbox.Text);
                int FCost = Convert.ToInt32(finalcosttextBox.Text);
                int change = AmountPaid - FCost;
                changetextbox.Text = change.ToString();
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SrNo = 0;
        }

        void getinvoiceid()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select invoice_id from order_master";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows.Count > 0)
            {
                int invoiceId = Convert.ToInt32(data.Rows[0]["invoice_id"]);
                invoicetextbox.Text = invoiceId.ToString();
            }
            else
            {
                string query2 = "select max(invoice_id) from order_master";
                SqlCommand cmd = new SqlCommand(query2, con);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    int maxInvoiceId = Convert.ToInt32(result) + 1;
                    invoicetextbox.Text = maxInvoiceId.ToString();
                }
                else
                {
                    invoicetextbox.Text = "1"; 
                }

                con.Close();
            }
        }


        private void insertbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into order_master values(@id,@user,@datetime,@finalcost)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", invoicetextbox.Text);
            cmd.Parameters.AddWithValue("@user", usertextbox.Text);
            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@finalcost", finalcosttextBox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if(a > 0)
            {
                MessageBox.Show("Inserted Successfully!!", " success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getinvoiceid();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Insertion Failed!!", " failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close() ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetItems();
        }

        private void quantitytextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if(ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void amountpaittextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void printpreviewbutton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1; 
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.royal_mart1;
            Image img = bmp;
            e.Graphics.DrawImage(img, 30, 5, 800, 250);
            e.Graphics.DrawString("Invoice Id: " + invoicetextbox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("User Name: " + usertextbox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToLongDateString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 420));
            e.Graphics.DrawString("ITEM: ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("PRICE: ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(240, 450));
            e.Graphics.DrawString("DISCOUNT: ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(390, 450));
            e.Graphics.DrawString("QUANTITY: ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(590, 450));

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 480));

            // ITEM NAME
            int gap = 510;
            if(dataGridView.Rows.Count > 0)
            {
                for(int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }

            // ITEM PRICE
            int gap1 = 510;
            if (dataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(260, gap1));
                        gap1 = gap1 + 30;
                    }
                    catch
                    {

                    }
                }
            }

            // ITEM DISCOUNT
            int gap2 = 510;
            if (dataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(410, gap2));
                        gap2 = gap2 + 30;
                    }
                    catch
                    {

                    }
                }
            }

            // ITEM QUANTITY
            int gap3 = 510;
            if (dataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(610, gap3));
                        gap3 = gap3 + 30;
                    }
                    catch
                    {

                    }
                }
            }

            int subtotalprint = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                subtotalprint = subtotalprint + Convert.ToInt32(dataGridView.Rows[i].Cells[5].Value);
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 900));
            e.Graphics.DrawString("Sub-Total: " + subtotalprint.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 930));

            int taxprint = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                taxprint = taxprint + Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value);
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 900));
            e.Graphics.DrawString("Tax: " + taxprint.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 960));
            e.Graphics.DrawString("Final Amount: " + finalcosttextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 990));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1020));
            e.Graphics.DrawString("Amount Paid: " + amountpaittextbox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1050));
            e.Graphics.DrawString("Change: " + changetextbox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1080));

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm adf = new AddItemForm();
            adf.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditItemForm edf = new EditItemForm();
            edf.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDataForm vdf = new ViewDataForm();
            vdf.ShowDialog();
        }

        private void totalcosttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalcosttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void invoicetextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
