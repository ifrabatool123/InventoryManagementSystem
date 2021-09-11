namespace SEproject
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contact_no = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BUT5GetData = new System.Windows.Forms.Button();
            this.BUT4Delete = new System.Windows.Forms.Button();
            this.BUT3Update = new System.Windows.Forms.Button();
            this.BUT2Save = new System.Windows.Forms.Button();
            this.BUT1New = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(253, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.contact_no);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(27, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 37);
            this.textBox1.TabIndex = 10;
            // 
            // contact_no
            // 
            this.contact_no.Location = new System.Drawing.Point(176, 258);
            this.contact_no.Name = "contact_no";
            this.contact_no.Size = new System.Drawing.Size(251, 37);
            this.contact_no.TabIndex = 9;
            this.contact_no.TextChanged += new System.EventHandler(this.contact_no_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(176, 196);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(251, 37);
            this.name.TabIndex = 8;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(176, 138);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(251, 37);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.BUT5GetData);
            this.panel1.Controls.Add(this.BUT4Delete);
            this.panel1.Controls.Add(this.BUT3Update);
            this.panel1.Controls.Add(this.BUT2Save);
            this.panel1.Controls.Add(this.BUT1New);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(561, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 323);
            this.panel1.TabIndex = 2;
            // 
            // BUT5GetData
            // 
            this.BUT5GetData.BackColor = System.Drawing.Color.DarkCyan;
            this.BUT5GetData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT5GetData.Location = new System.Drawing.Point(33, 262);
            this.BUT5GetData.Name = "BUT5GetData";
            this.BUT5GetData.Size = new System.Drawing.Size(162, 32);
            this.BUT5GetData.TabIndex = 4;
            this.BUT5GetData.Text = "&Get Data";
            this.BUT5GetData.UseVisualStyleBackColor = false;
            this.BUT5GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // BUT4Delete
            // 
            this.BUT4Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.BUT4Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT4Delete.Location = new System.Drawing.Point(33, 203);
            this.BUT4Delete.Name = "BUT4Delete";
            this.BUT4Delete.Size = new System.Drawing.Size(162, 32);
            this.BUT4Delete.TabIndex = 3;
            this.BUT4Delete.Text = "&Delete";
            this.BUT4Delete.UseVisualStyleBackColor = false;
            this.BUT4Delete.Click += new System.EventHandler(this.BUT4Delete_Click);
            // 
            // BUT3Update
            // 
            this.BUT3Update.BackColor = System.Drawing.Color.DarkCyan;
            this.BUT3Update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT3Update.Location = new System.Drawing.Point(33, 142);
            this.BUT3Update.Name = "BUT3Update";
            this.BUT3Update.Size = new System.Drawing.Size(162, 32);
            this.BUT3Update.TabIndex = 2;
            this.BUT3Update.Text = "&Update";
            this.BUT3Update.UseVisualStyleBackColor = false;
            this.BUT3Update.Click += new System.EventHandler(this.BUT3Update_Click);
            // 
            // BUT2Save
            // 
            this.BUT2Save.BackColor = System.Drawing.Color.DarkCyan;
            this.BUT2Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT2Save.Location = new System.Drawing.Point(33, 81);
            this.BUT2Save.Name = "BUT2Save";
            this.BUT2Save.Size = new System.Drawing.Size(162, 32);
            this.BUT2Save.TabIndex = 1;
            this.BUT2Save.Text = "&Save";
            this.BUT2Save.UseVisualStyleBackColor = false;
            this.BUT2Save.Click += new System.EventHandler(this.BUT2Save_Click);
            // 
            // BUT1New
            // 
            this.BUT1New.BackColor = System.Drawing.Color.DarkCyan;
            this.BUT1New.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT1New.Location = new System.Drawing.Point(33, 21);
            this.BUT1New.Name = "BUT1New";
            this.BUT1New.Size = new System.Drawing.Size(162, 32);
            this.BUT1New.TabIndex = 0;
            this.BUT1New.Text = "&New";
            this.BUT1New.UseVisualStyleBackColor = false;
            this.BUT1New.Click += new System.EventHandler(this.BUT1New_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEproject.Properties.Resources.images__4_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(832, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contact_no;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BUT5GetData;
        private System.Windows.Forms.Button BUT4Delete;
        private System.Windows.Forms.Button BUT3Update;
        private System.Windows.Forms.Button BUT2Save;
        private System.Windows.Forms.Button BUT1New;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}