namespace Shopping_Mart_Application
{
    partial class EditItemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.discounttextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.discounttextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pricetextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.idtextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nametextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(142, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 292);
            this.panel1.TabIndex = 16;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Silver;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(201, 236);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(123, 39);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.Silver;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(65, 236);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(116, 39);
            this.updatebutton.TabIndex = 4;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // discounttextbox
            // 
            this.discounttextbox.BackColor = System.Drawing.Color.Silver;
            this.discounttextbox.Location = new System.Drawing.Point(147, 194);
            this.discounttextbox.Name = "discounttextbox";
            this.discounttextbox.Size = new System.Drawing.Size(196, 22);
            this.discounttextbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "DISCOUNT";
            // 
            // pricetextbox
            // 
            this.pricetextbox.BackColor = System.Drawing.Color.Silver;
            this.pricetextbox.Location = new System.Drawing.Point(147, 151);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(196, 22);
            this.pricetextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "PRICE";
            // 
            // idtextbox
            // 
            this.idtextbox.BackColor = System.Drawing.Color.Silver;
            this.idtextbox.Location = new System.Drawing.Point(147, 72);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.ReadOnly = true;
            this.idtextbox.Size = new System.Drawing.Size(196, 22);
            this.idtextbox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // nametextbox
            // 
            this.nametextbox.BackColor = System.Drawing.Color.Silver;
            this.nametextbox.Location = new System.Drawing.Point(147, 110);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(196, 22);
            this.nametextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Shopping_Mart_Application.Properties.Resources.royal_mart;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 193);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(661, 687);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "EditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItemForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.TextBox discounttextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}