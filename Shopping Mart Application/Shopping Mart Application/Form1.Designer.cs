namespace Shopping_Mart_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.invoicetextbox = new System.Windows.Forms.TextBox();
            this.usertextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectitemcombox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unitpricetextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discounttextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantitytextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.subtotaltextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.taxtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalcosttextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.finalcosttextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.amountpaittextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.changetextbox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clearbutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.printpreviewbutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice No";
            // 
            // invoicetextbox
            // 
            this.invoicetextbox.BackColor = System.Drawing.Color.LightGray;
            this.invoicetextbox.Location = new System.Drawing.Point(14, 221);
            this.invoicetextbox.Name = "invoicetextbox";
            this.invoicetextbox.ReadOnly = true;
            this.invoicetextbox.Size = new System.Drawing.Size(180, 22);
            this.invoicetextbox.TabIndex = 2;
            this.invoicetextbox.TextChanged += new System.EventHandler(this.invoicetextbox_TextChanged);
            // 
            // usertextbox
            // 
            this.usertextbox.BackColor = System.Drawing.Color.LightGray;
            this.usertextbox.Location = new System.Drawing.Point(14, 274);
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.ReadOnly = true;
            this.usertextbox.Size = new System.Drawing.Size(180, 22);
            this.usertextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Invoice No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Item";
            // 
            // selectitemcombox
            // 
            this.selectitemcombox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectitemcombox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectitemcombox.BackColor = System.Drawing.Color.LightGray;
            this.selectitemcombox.FormattingEnabled = true;
            this.selectitemcombox.Items.AddRange(new object[] {
            "pasta",
            "milk",
            "ghee"});
            this.selectitemcombox.Location = new System.Drawing.Point(14, 328);
            this.selectitemcombox.Name = "selectitemcombox";
            this.selectitemcombox.Size = new System.Drawing.Size(180, 24);
            this.selectitemcombox.TabIndex = 0;
            this.selectitemcombox.SelectedIndexChanged += new System.EventHandler(this.selectitemcombox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Unit Price";
            // 
            // unitpricetextbox
            // 
            this.unitpricetextbox.BackColor = System.Drawing.Color.LightGray;
            this.unitpricetextbox.Location = new System.Drawing.Point(14, 387);
            this.unitpricetextbox.Name = "unitpricetextbox";
            this.unitpricetextbox.ReadOnly = true;
            this.unitpricetextbox.Size = new System.Drawing.Size(180, 22);
            this.unitpricetextbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Discount Per Item";
            // 
            // discounttextbox
            // 
            this.discounttextbox.BackColor = System.Drawing.Color.LightGray;
            this.discounttextbox.Location = new System.Drawing.Point(11, 447);
            this.discounttextbox.Name = "discounttextbox";
            this.discounttextbox.ReadOnly = true;
            this.discounttextbox.Size = new System.Drawing.Size(180, 22);
            this.discounttextbox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quantity";
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.BackColor = System.Drawing.Color.LightGray;
            this.quantitytextbox.Enabled = false;
            this.quantitytextbox.Location = new System.Drawing.Point(244, 221);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.Size = new System.Drawing.Size(180, 22);
            this.quantitytextbox.TabIndex = 3;
            this.quantitytextbox.TextChanged += new System.EventHandler(this.quantitytextbox_TextChanged);
            this.quantitytextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytextbox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(241, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sub Total";
            // 
            // subtotaltextBox
            // 
            this.subtotaltextBox.BackColor = System.Drawing.Color.LightGray;
            this.subtotaltextBox.Location = new System.Drawing.Point(244, 274);
            this.subtotaltextBox.Name = "subtotaltextBox";
            this.subtotaltextBox.ReadOnly = true;
            this.subtotaltextBox.Size = new System.Drawing.Size(180, 22);
            this.subtotaltextBox.TabIndex = 4;
            this.subtotaltextBox.TextChanged += new System.EventHandler(this.subtotaltextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tax";
            // 
            // taxtextBox
            // 
            this.taxtextBox.BackColor = System.Drawing.Color.LightGray;
            this.taxtextBox.Location = new System.Drawing.Point(244, 328);
            this.taxtextBox.Name = "taxtextBox";
            this.taxtextBox.ReadOnly = true;
            this.taxtextBox.Size = new System.Drawing.Size(180, 22);
            this.taxtextBox.TabIndex = 5;
            this.taxtextBox.TextChanged += new System.EventHandler(this.taxtextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(241, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "total Cost";
            // 
            // totalcosttextBox
            // 
            this.totalcosttextBox.BackColor = System.Drawing.Color.LightGray;
            this.totalcosttextBox.Location = new System.Drawing.Point(244, 387);
            this.totalcosttextBox.Name = "totalcosttextBox";
            this.totalcosttextBox.ReadOnly = true;
            this.totalcosttextBox.Size = new System.Drawing.Size(180, 22);
            this.totalcosttextBox.TabIndex = 6;
            this.totalcosttextBox.TextChanged += new System.EventHandler(this.totalcosttextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(241, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Final Cost";
            // 
            // finalcosttextBox
            // 
            this.finalcosttextBox.BackColor = System.Drawing.Color.LightGray;
            this.finalcosttextBox.Location = new System.Drawing.Point(244, 447);
            this.finalcosttextBox.Name = "finalcosttextBox";
            this.finalcosttextBox.ReadOnly = true;
            this.finalcosttextBox.Size = new System.Drawing.Size(180, 22);
            this.finalcosttextBox.TabIndex = 7;
            this.finalcosttextBox.TextChanged += new System.EventHandler(this.finalcosttextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(462, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Amount Paid";
            // 
            // amountpaittextbox
            // 
            this.amountpaittextbox.BackColor = System.Drawing.Color.LightGray;
            this.amountpaittextbox.Location = new System.Drawing.Point(465, 221);
            this.amountpaittextbox.Name = "amountpaittextbox";
            this.amountpaittextbox.Size = new System.Drawing.Size(180, 22);
            this.amountpaittextbox.TabIndex = 8;
            this.amountpaittextbox.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.amountpaittextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountpaittextbox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "change";
            // 
            // changetextbox
            // 
            this.changetextbox.BackColor = System.Drawing.Color.LightGray;
            this.changetextbox.Location = new System.Drawing.Point(465, 274);
            this.changetextbox.Name = "changetextbox";
            this.changetextbox.ReadOnly = true;
            this.changetextbox.Size = new System.Drawing.Size(180, 22);
            this.changetextbox.TabIndex = 9;
            this.changetextbox.TextChanged += new System.EventHandler(this.changetextbox_TextChanged);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.LightGray;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(11, 493);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(86, 28);
            this.addbutton.TabIndex = 10;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.LightGray;
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(100, 493);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(91, 28);
            this.resetbutton.TabIndex = 11;
            this.resetbutton.Text = "RESET";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 539);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(636, 220);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.LightGray;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(550, 765);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(95, 33);
            this.clearbutton.TabIndex = 13;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.BackColor = System.Drawing.Color.LightGray;
            this.insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.Location = new System.Drawing.Point(198, 493);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(106, 28);
            this.insertbutton.TabIndex = 14;
            this.insertbutton.Text = "INSERT";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // printpreviewbutton
            // 
            this.printpreviewbutton.BackColor = System.Drawing.Color.LightGray;
            this.printpreviewbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printpreviewbutton.Location = new System.Drawing.Point(487, 318);
            this.printpreviewbutton.Name = "printpreviewbutton";
            this.printpreviewbutton.Size = new System.Drawing.Size(149, 66);
            this.printpreviewbutton.TabIndex = 15;
            this.printpreviewbutton.Text = "PRINT PREVIEW";
            this.printpreviewbutton.UseVisualStyleBackColor = false;
            this.printpreviewbutton.Click += new System.EventHandler(this.printpreviewbutton_Click);
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.LightGray;
            this.printbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.Location = new System.Drawing.Point(487, 403);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(149, 66);
            this.printbutton.TabIndex = 15;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDataToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Shopping_Mart_Application.Properties.Resources.royal_mart;
            this.pictureBox1.Location = new System.Drawing.Point(3, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(661, 804);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.printpreviewbutton);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.selectitemcombox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changetextbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.amountpaittextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.finalcosttextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalcosttextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.taxtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.subtotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantitytextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.discounttextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unitpricetextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usertextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoicetextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Mart";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoicetextbox;
        private System.Windows.Forms.TextBox usertextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectitemcombox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unitpricetextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discounttextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantitytextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox subtotaltextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox taxtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalcosttextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox finalcosttextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox amountpaittextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox changetextbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button printpreviewbutton;
        private System.Windows.Forms.Button printbutton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

