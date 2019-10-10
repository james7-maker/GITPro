namespace Login
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductDetails = new System.Windows.Forms.Panel();
            this.gbQuantity = new System.Windows.Forms.GroupBox();
            this.rbTen = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbEight = new System.Windows.Forms.RadioButton();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.chkFullset = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkBasic = new System.Windows.Forms.CheckBox();
            this.chkScientific = new System.Windows.Forms.CheckBox();
            this.gbProductName = new System.Windows.Forms.GroupBox();
            this.Product = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FirstOutput = new System.Windows.Forms.ListBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inventoryDataSet = new login.InventoryDataSet();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailsTableAdapter = new login.InventoryDataSetTableAdapters.CustomerDetailsTableAdapter();
            this.customerDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ProductDetails.SuspendLayout();
            this.gbQuantity.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.gbProductName.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(43, 528);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 24);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(276, 528);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(494, 528);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 24);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = " Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(752, 528);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 112);
            this.panel1.TabIndex = 4;
            // 
            // ProductDetails
            // 
            this.ProductDetails.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProductDetails.Controls.Add(this.gbQuantity);
            this.ProductDetails.Controls.Add(this.gbClass);
            this.ProductDetails.Controls.Add(this.gbProductName);
            this.ProductDetails.Location = new System.Drawing.Point(0, 124);
            this.ProductDetails.Name = "ProductDetails";
            this.ProductDetails.Size = new System.Drawing.Size(915, 207);
            this.ProductDetails.TabIndex = 5;
            // 
            // gbQuantity
            // 
            this.gbQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.gbQuantity.Controls.Add(this.rbTen);
            this.gbQuantity.Controls.Add(this.rbTwo);
            this.gbQuantity.Controls.Add(this.rbEight);
            this.gbQuantity.Controls.Add(this.rbFour);
            this.gbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuantity.Location = new System.Drawing.Point(652, 21);
            this.gbQuantity.Name = "gbQuantity";
            this.gbQuantity.Size = new System.Drawing.Size(200, 172);
            this.gbQuantity.TabIndex = 2;
            this.gbQuantity.TabStop = false;
            this.gbQuantity.Text = "Quantity";
            // 
            // rbTen
            // 
            this.rbTen.Location = new System.Drawing.Point(6, 129);
            this.rbTen.Name = "rbTen";
            this.rbTen.Size = new System.Drawing.Size(85, 43);
            this.rbTen.TabIndex = 3;
            this.rbTen.TabStop = true;
            this.rbTen.Text = "10";
            this.rbTen.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.Location = new System.Drawing.Point(6, 91);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(85, 40);
            this.rbTwo.TabIndex = 2;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // rbEight
            // 
            this.rbEight.Location = new System.Drawing.Point(6, 51);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(85, 45);
            this.rbEight.TabIndex = 1;
            this.rbEight.TabStop = true;
            this.rbEight.Text = "8";
            this.rbEight.UseVisualStyleBackColor = true;
            // 
            // rbFour
            // 
            this.rbFour.Location = new System.Drawing.Point(6, 19);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(85, 41);
            this.rbFour.TabIndex = 0;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // gbClass
            // 
            this.gbClass.BackColor = System.Drawing.SystemColors.Control;
            this.gbClass.Controls.Add(this.chkFullset);
            this.gbClass.Controls.Add(this.chkOther);
            this.gbClass.Controls.Add(this.chkBasic);
            this.gbClass.Controls.Add(this.chkScientific);
            this.gbClass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClass.Location = new System.Drawing.Point(324, 21);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(200, 172);
            this.gbClass.TabIndex = 1;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "Class";
            // 
            // chkFullset
            // 
            this.chkFullset.AutoSize = true;
            this.chkFullset.Location = new System.Drawing.Point(18, 143);
            this.chkFullset.Name = "chkFullset";
            this.chkFullset.Size = new System.Drawing.Size(68, 20);
            this.chkFullset.TabIndex = 3;
            this.chkFullset.Text = "Fullset";
            this.chkFullset.UseVisualStyleBackColor = true;
            this.chkFullset.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(18, 104);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(62, 20);
            this.chkOther.TabIndex = 2;
            this.chkOther.Text = "Other";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // chkBasic
            // 
            this.chkBasic.AutoSize = true;
            this.chkBasic.Location = new System.Drawing.Point(18, 67);
            this.chkBasic.Name = "chkBasic";
            this.chkBasic.Size = new System.Drawing.Size(58, 20);
            this.chkBasic.TabIndex = 1;
            this.chkBasic.Text = "Basic";
            this.chkBasic.UseVisualStyleBackColor = true;
            // 
            // chkScientific
            // 
            this.chkScientific.AutoSize = true;
            this.chkScientific.Location = new System.Drawing.Point(18, 27);
            this.chkScientific.Name = "chkScientific";
            this.chkScientific.Size = new System.Drawing.Size(83, 20);
            this.chkScientific.TabIndex = 0;
            this.chkScientific.Text = "Scientific";
            this.chkScientific.UseVisualStyleBackColor = true;
            // 
            // gbProductName
            // 
            this.gbProductName.BackColor = System.Drawing.SystemColors.Control;
            this.gbProductName.Controls.Add(this.Product);
            this.gbProductName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductName.Location = new System.Drawing.Point(27, 21);
            this.gbProductName.Name = "gbProductName";
            this.gbProductName.Size = new System.Drawing.Size(200, 172);
            this.gbProductName.TabIndex = 0;
            this.gbProductName.TabStop = false;
            this.gbProductName.Text = "ProductName";
            // 
            // Product
            // 
            this.Product.FormattingEnabled = true;
            this.Product.ItemHeight = 16;
            this.Product.Items.AddRange(new object[] {
            "Casio",
            "WriteView",
            "fx2zl",
            "Sharp"});
            this.Product.Location = new System.Drawing.Point(13, 27);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(169, 132);
            this.Product.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.FirstOutput);
            this.panel3.Location = new System.Drawing.Point(0, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 185);
            this.panel3.TabIndex = 5;
            // 
            // FirstOutput
            // 
            this.FirstOutput.FormattingEnabled = true;
            this.FirstOutput.Items.AddRange(new object[] {
            "Ist Output"});
            this.FirstOutput.Location = new System.Drawing.Point(45, 18);
            this.FirstOutput.Name = "FirstOutput";
            this.FirstOutput.Size = new System.Drawing.Size(834, 147);
            this.FirstOutput.TabIndex = 0;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(124, 86);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(155, 24);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(396, 33);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(162, 24);
            this.txtLastname.TabIndex = 7;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(124, 32);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(155, 24);
            this.txtCustomerID.TabIndex = 8;
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Visa Card",
            "Master Card",
            "Debit Card"});
            this.cmbPayment.Location = new System.Drawing.Point(711, 76);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(191, 21);
            this.cmbPayment.TabIndex = 9;
            this.cmbPayment.Text = "Select Type";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "Inshop",
            "Online",
            "Telephone"});
            this.cmbOrder.Location = new System.Drawing.Point(396, 83);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(162, 21);
            this.cmbOrder.TabIndex = 10;
            this.cmbOrder.Text = "Select Order";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(711, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsBindingSource, "CustomerID", true));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "CustomerID:";
            // 
            // label2
            // 
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryDataSet, "CustomerDetails.FirstName", true));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsBindingSource1, "LastName", true));
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsBindingSource1, "Order", true));
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Order ";
            // 
            // label5
            // 
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsBindingSource, "DateOfOrder", true));
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date Ordered";
            // 
            // label6
            // 
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsBindingSource, "MethodOfPayment", true));
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Method Of Payment";
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.inventoryDataSet;
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // customerDetailsBindingSource1
            // 
            this.customerDetailsBindingSource1.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource1.DataSource = this.inventoryDataSet;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ProductDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ProductDetails.ResumeLayout(false);
            this.gbQuantity.ResumeLayout(false);
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.gbProductName.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ProductDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbQuantity;
        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.CheckBox chkFullset;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkBasic;
        private System.Windows.Forms.CheckBox chkScientific;
        private System.Windows.Forms.GroupBox gbProductName;
        private System.Windows.Forms.ListBox Product;
        private System.Windows.Forms.ListBox FirstOutput;
        private System.Windows.Forms.RadioButton rbTen;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbEight;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private login.InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private login.InventoryDataSetTableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource1;
    }
}