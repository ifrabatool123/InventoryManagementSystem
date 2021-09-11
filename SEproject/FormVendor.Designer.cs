namespace SEproject
{
    partial class FormVendor
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
            this.notes = new System.Windows.Forms.TextBox();
            this.fax_no = new System.Windows.Forms.TextBox();
            this.mobile_no = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.zipcode = new System.Windows.Forms.MaskedTextBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.landmark = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.vendorid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BU4Delete = new System.Windows.Forms.Button();
            this.BU3Update = new System.Windows.Forms.Button();
            this.BU2Save = new System.Windows.Forms.Button();
            this.BU1New = new System.Windows.Forms.Button();
            this.Vendor_id = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vendor_id)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.notes);
            this.panel1.Controls.Add(this.fax_no);
            this.panel1.Controls.Add(this.mobile_no);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.city);
            this.panel1.Controls.Add(this.zipcode);
            this.panel1.Controls.Add(this.state);
            this.panel1.Controls.Add(this.landmark);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.vendorid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(86, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 578);
            this.panel1.TabIndex = 0;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(140, 474);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(319, 72);
            this.notes.TabIndex = 33;
            // 
            // fax_no
            // 
            this.fax_no.Location = new System.Drawing.Point(140, 438);
            this.fax_no.Name = "fax_no";
            this.fax_no.Size = new System.Drawing.Size(222, 27);
            this.fax_no.TabIndex = 32;
            // 
            // mobile_no
            // 
            this.mobile_no.Location = new System.Drawing.Point(140, 397);
            this.mobile_no.Mask = "00000000000";
            this.mobile_no.Name = "mobile_no";
            this.mobile_no.Size = new System.Drawing.Size(257, 27);
            this.mobile_no.TabIndex = 31;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(140, 358);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(319, 27);
            this.email.TabIndex = 30;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(140, 315);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(222, 27);
            this.phone.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 480);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 19);
            this.label21.TabIndex = 27;
            this.label21.Text = "Notes";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 441);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 19);
            this.label20.TabIndex = 26;
            this.label20.Text = "Fax No.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 400);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 19);
            this.label19.TabIndex = 25;
            this.label19.Text = "*Mobile No.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 19);
            this.label18.TabIndex = 24;
            this.label18.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Phone";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(140, 198);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(222, 27);
            this.city.TabIndex = 21;
            // 
            // zipcode
            // 
            this.zipcode.Location = new System.Drawing.Point(140, 272);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(222, 27);
            this.zipcode.TabIndex = 20;
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Location = new System.Drawing.Point(140, 238);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(319, 27);
            this.state.TabIndex = 19;
            // 
            // landmark
            // 
            this.landmark.Location = new System.Drawing.Point(140, 157);
            this.landmark.Name = "landmark";
            this.landmark.Size = new System.Drawing.Size(319, 27);
            this.landmark.TabIndex = 18;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(140, 118);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(319, 27);
            this.address.TabIndex = 17;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(140, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(319, 27);
            this.name.TabIndex = 16;
            // 
            // vendorid
            // 
            this.vendorid.Location = new System.Drawing.Point(140, 48);
            this.vendorid.Name = "vendorid";
            this.vendorid.Size = new System.Drawing.Size(222, 27);
            this.vendorid.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "*ZipCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "*State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "*City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Landmark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "*Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendor ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.BU4Delete);
            this.panel3.Controls.Add(this.BU3Update);
            this.panel3.Controls.Add(this.BU2Save);
            this.panel3.Controls.Add(this.BU1New);
            this.panel3.Location = new System.Drawing.Point(672, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 300);
            this.panel3.TabIndex = 16;
            // 
            // BU4Delete
            // 
            this.BU4Delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BU4Delete.Location = new System.Drawing.Point(23, 204);
            this.BU4Delete.Name = "BU4Delete";
            this.BU4Delete.Size = new System.Drawing.Size(105, 39);
            this.BU4Delete.TabIndex = 33;
            this.BU4Delete.Text = "Delete";
            this.BU4Delete.UseVisualStyleBackColor = false;
            this.BU4Delete.Click += new System.EventHandler(this.BU4Delete_Click);
            // 
            // BU3Update
            // 
            this.BU3Update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BU3Update.Location = new System.Drawing.Point(23, 146);
            this.BU3Update.Name = "BU3Update";
            this.BU3Update.Size = new System.Drawing.Size(105, 39);
            this.BU3Update.TabIndex = 32;
            this.BU3Update.Text = "Update";
            this.BU3Update.UseVisualStyleBackColor = false;
            this.BU3Update.Click += new System.EventHandler(this.BU3Update_Click);
            // 
            // BU2Save
            // 
            this.BU2Save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BU2Save.Location = new System.Drawing.Point(23, 94);
            this.BU2Save.Name = "BU2Save";
            this.BU2Save.Size = new System.Drawing.Size(105, 39);
            this.BU2Save.TabIndex = 31;
            this.BU2Save.Text = "Save";
            this.BU2Save.UseVisualStyleBackColor = false;
            this.BU2Save.Click += new System.EventHandler(this.BU2Save_Click);
            // 
            // BU1New
            // 
            this.BU1New.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BU1New.Location = new System.Drawing.Point(23, 37);
            this.BU1New.Name = "BU1New";
            this.BU1New.Size = new System.Drawing.Size(105, 39);
            this.BU1New.TabIndex = 30;
            this.BU1New.Text = "New";
            this.BU1New.UseVisualStyleBackColor = false;
            this.BU1New.Click += new System.EventHandler(this.BU1New_Click);
            // 
            // Vendor_id
            // 
            this.Vendor_id.Image = global::SEproject.Properties.Resources.images__4_;
            this.Vendor_id.Location = new System.Drawing.Point(-1, 1);
            this.Vendor_id.Name = "Vendor_id";
            this.Vendor_id.Size = new System.Drawing.Size(932, 628);
            this.Vendor_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vendor_id.TabIndex = 17;
            this.Vendor_id.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(383, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 27);
            this.button1.TabIndex = 30;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(925, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Vendor_id);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVendor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vendor_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.MaskedTextBox zipcode;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.TextBox landmark;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox vendorid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.TextBox fax_no;
        private System.Windows.Forms.MaskedTextBox mobile_no;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BU4Delete;
        private System.Windows.Forms.Button BU3Update;
        private System.Windows.Forms.Button BU2Save;
        private System.Windows.Forms.Button BU1New;
        private System.Windows.Forms.PictureBox Vendor_id;
        private System.Windows.Forms.Button button1;
    }
}