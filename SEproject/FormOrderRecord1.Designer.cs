namespace SEproject
{
    partial class FormOrderRecord1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Getbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combStatus = new System.Windows.Forms.ComboBox();
            this.StatusResetBUT = new System.Windows.Forms.Button();
            this.StatusGetBUT = new System.Windows.Forms.Button();
            this.productReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.combProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combDistributor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCstomrName = new System.Windows.Forms.TextBox();
            this.DisReset = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.dataGrid1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "By Order No.";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(22, 138);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(799, 345);
            this.dataGrid1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.comOrder);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 85);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // comOrder
            // 
            this.comOrder.FormattingEnabled = true;
            this.comOrder.Location = new System.Drawing.Point(17, 39);
            this.comOrder.Name = "comOrder";
            this.comOrder.Size = new System.Drawing.Size(227, 27);
            this.comOrder.TabIndex = 1;
            this.comOrder.SelectedIndexChanged += new System.EventHandler(this.comOrder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 538);
            this.tabControl1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(71, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 11;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(279, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MMM/yyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MMM/yyy";
            this.dateTimePicker2.Location = new System.Drawing.Point(208, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Getbutton
            // 
            this.Getbutton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Getbutton.Location = new System.Drawing.Point(32, 26);
            this.Getbutton.Name = "Getbutton";
            this.Getbutton.Size = new System.Drawing.Size(90, 35);
            this.Getbutton.TabIndex = 0;
            this.Getbutton.Text = "&Get Data";
            this.Getbutton.UseVisualStyleBackColor = false;
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Resetbutton.Location = new System.Drawing.Point(159, 26);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(90, 35);
            this.Resetbutton.TabIndex = 1;
            this.Resetbutton.Text = "&Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(22, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 0;
            // 
            // combStatus
            // 
            this.combStatus.FormattingEnabled = true;
            this.combStatus.Location = new System.Drawing.Point(17, 39);
            this.combStatus.Name = "combStatus";
            this.combStatus.Size = new System.Drawing.Size(227, 21);
            this.combStatus.TabIndex = 1;
            // 
            // StatusResetBUT
            // 
            this.StatusResetBUT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.StatusResetBUT.Location = new System.Drawing.Point(176, 26);
            this.StatusResetBUT.Name = "StatusResetBUT";
            this.StatusResetBUT.Size = new System.Drawing.Size(104, 40);
            this.StatusResetBUT.TabIndex = 3;
            this.StatusResetBUT.Text = "&Reset";
            this.StatusResetBUT.UseVisualStyleBackColor = false;
            // 
            // StatusGetBUT
            // 
            this.StatusGetBUT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.StatusGetBUT.Location = new System.Drawing.Point(47, 26);
            this.StatusGetBUT.Name = "StatusGetBUT";
            this.StatusGetBUT.Size = new System.Drawing.Size(104, 40);
            this.StatusGetBUT.TabIndex = 4;
            this.StatusGetBUT.Text = "&Get Data";
            this.StatusGetBUT.UseVisualStyleBackColor = false;
            // 
            // productReset
            // 
            this.productReset.BackColor = System.Drawing.Color.DarkSlateGray;
            this.productReset.Location = new System.Drawing.Point(67, 26);
            this.productReset.Name = "productReset";
            this.productReset.Size = new System.Drawing.Size(104, 40);
            this.productReset.TabIndex = 3;
            this.productReset.Text = "&Reset";
            this.productReset.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(22, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 0;
            // 
            // combProduct
            // 
            this.combProduct.FormattingEnabled = true;
            this.combProduct.Location = new System.Drawing.Point(17, 39);
            this.combProduct.Name = "combProduct";
            this.combProduct.Size = new System.Drawing.Size(227, 21);
            this.combProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 0;
            // 
            // textPrductName
            // 
            this.textPrductName.Location = new System.Drawing.Point(17, 40);
            this.textPrductName.Name = "textPrductName";
            this.textPrductName.Size = new System.Drawing.Size(231, 20);
            this.textPrductName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(22, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 0;
            // 
            // combDistributor
            // 
            this.combDistributor.FormattingEnabled = true;
            this.combDistributor.Location = new System.Drawing.Point(17, 39);
            this.combDistributor.Name = "combDistributor";
            this.combDistributor.Size = new System.Drawing.Size(227, 21);
            this.combDistributor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(22, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 0;
            // 
            // textCstomrName
            // 
            this.textCstomrName.Location = new System.Drawing.Point(17, 40);
            this.textCstomrName.Name = "textCstomrName";
            this.textCstomrName.Size = new System.Drawing.Size(231, 20);
            this.textCstomrName.TabIndex = 1;
            // 
            // DisReset
            // 
            this.DisReset.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DisReset.Location = new System.Drawing.Point(83, 26);
            this.DisReset.Name = "DisReset";
            this.DisReset.Size = new System.Drawing.Size(104, 40);
            this.DisReset.TabIndex = 3;
            this.DisReset.Text = "&Reset";
            this.DisReset.UseVisualStyleBackColor = false;
            // 
            // FormOrderRecord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(916, 589);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrderRecord1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderRecord1";
            this.Load += new System.EventHandler(this.FormOrderRecord1_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Getbutton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combStatus;
        private System.Windows.Forms.Button StatusResetBUT;
        private System.Windows.Forms.Button StatusGetBUT;
        private System.Windows.Forms.Button productReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combDistributor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCstomrName;
        private System.Windows.Forms.Button DisReset;
        private System.Windows.Forms.DataGrid dataGrid1;
    }
}