namespace SEproject
{
    partial class FormProduct
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BDelete = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.BNew = new System.Windows.Forms.Button();
            this.Product_Details = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.weight = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.textPROID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.Product_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.BDelete);
            this.panel3.Controls.Add(this.BUpdate);
            this.panel3.Controls.Add(this.BSave);
            this.panel3.Controls.Add(this.BNew);
            this.panel3.Location = new System.Drawing.Point(582, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 281);
            this.panel3.TabIndex = 17;
            // 
            // BDelete
            // 
            this.BDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BDelete.Location = new System.Drawing.Point(23, 204);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(105, 39);
            this.BDelete.TabIndex = 33;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = false;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BUpdate.Location = new System.Drawing.Point(23, 146);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(105, 39);
            this.BUpdate.TabIndex = 32;
            this.BUpdate.Text = "Update";
            this.BUpdate.UseVisualStyleBackColor = false;
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BSave.Location = new System.Drawing.Point(23, 94);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(105, 39);
            this.BSave.TabIndex = 31;
            this.BSave.Text = "Save";
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BNew
            // 
            this.BNew.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BNew.Location = new System.Drawing.Point(23, 37);
            this.BNew.Name = "BNew";
            this.BNew.Size = new System.Drawing.Size(105, 39);
            this.BNew.TabIndex = 30;
            this.BNew.Text = "New";
            this.BNew.UseVisualStyleBackColor = false;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // Product_Details
            // 
            this.Product_Details.BackColor = System.Drawing.Color.DarkCyan;
            this.Product_Details.Controls.Add(this.button1);
            this.Product_Details.Controls.Add(this.weight);
            this.Product_Details.Controls.Add(this.label5);
            this.Product_Details.Controls.Add(this.label4);
            this.Product_Details.Controls.Add(this.label3);
            this.Product_Details.Controls.Add(this.label2);
            this.Product_Details.Controls.Add(this.label1);
            this.Product_Details.Controls.Add(this.category);
            this.Product_Details.Controls.Add(this.price);
            this.Product_Details.Controls.Add(this.name);
            this.Product_Details.Controls.Add(this.textPROID);
            this.Product_Details.Location = new System.Drawing.Point(38, 86);
            this.Product_Details.Name = "Product_Details";
            this.Product_Details.Size = new System.Drawing.Size(479, 366);
            this.Product_Details.TabIndex = 18;
            this.Product_Details.TabStop = false;
            this.Product_Details.Text = "Product Details";
            this.Product_Details.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(395, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 27);
            this.button1.TabIndex = 35;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weight
            // 
            this.weight.FormattingEnabled = true;
            this.weight.Location = new System.Drawing.Point(148, 214);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(223, 27);
            this.weight.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Weight(Per Qty)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Product ID";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(148, 171);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(302, 27);
            this.category.TabIndex = 35;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(148, 251);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(223, 27);
            this.price.TabIndex = 34;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(148, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(302, 27);
            this.name.TabIndex = 33;
            // 
            // textPROID
            // 
            this.textPROID.Location = new System.Drawing.Point(148, 89);
            this.textPROID.Name = "textPROID";
            this.textPROID.Size = new System.Drawing.Size(223, 27);
            this.textPROID.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEproject.Properties.Resources.images__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(141, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(486, 36);
            this.label6.TabIndex = 20;
            this.label6.Text = "ENTER PRODUCT RECORDS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(782, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Product_Details);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct";
            this.panel3.ResumeLayout(false);
            this.Product_Details.ResumeLayout(false);
            this.Product_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BNew;
        private System.Windows.Forms.GroupBox Product_Details;
        private System.Windows.Forms.ComboBox weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox textPROID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}