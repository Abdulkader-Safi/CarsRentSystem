namespace CarsRentSystem.View
{
    partial class CustomerPage
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
            this.tbcCustomer = new System.Windows.Forms.TabControl();
            this.Preview = new System.Windows.Forms.TabPage();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.pnlPreviewData = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.pnlPreviewTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.TabPage();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInsertCustomer = new System.Windows.Forms.Label();
            this.inpPhoneNumber = new System.Windows.Forms.TextBox();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.inpFullName = new System.Windows.Forms.TextBox();
            this.btnInsertCancel = new System.Windows.Forms.Button();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.tbcCustomer.SuspendLayout();
            this.Preview.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.pnlPreviewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlPreviewTop.SuspendLayout();
            this.Insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCustomer
            // 
            this.tbcCustomer.Controls.Add(this.Preview);
            this.tbcCustomer.Controls.Add(this.Insert);
            this.tbcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.tbcCustomer.Location = new System.Drawing.Point(0, 0);
            this.tbcCustomer.Name = "tbcCustomer";
            this.tbcCustomer.SelectedIndex = 0;
            this.tbcCustomer.Size = new System.Drawing.Size(998, 661);
            this.tbcCustomer.TabIndex = 0;
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.pnlPreview);
            this.Preview.Location = new System.Drawing.Point(4, 31);
            this.Preview.Name = "Preview";
            this.Preview.Padding = new System.Windows.Forms.Padding(3);
            this.Preview.Size = new System.Drawing.Size(990, 626);
            this.Preview.TabIndex = 0;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.pnlPreviewData);
            this.pnlPreview.Controls.Add(this.pnlPreviewTop);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Location = new System.Drawing.Point(3, 3);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(984, 620);
            this.pnlPreview.TabIndex = 0;
            // 
            // pnlPreviewData
            // 
            this.pnlPreviewData.Controls.Add(this.dgvCustomers);
            this.pnlPreviewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreviewData.Location = new System.Drawing.Point(0, 101);
            this.pnlPreviewData.Name = "pnlPreviewData";
            this.pnlPreviewData.Size = new System.Drawing.Size(984, 519);
            this.pnlPreviewData.TabIndex = 1;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(984, 519);
            this.dgvCustomers.TabIndex = 0;
            // 
            // pnlPreviewTop
            // 
            this.pnlPreviewTop.Controls.Add(this.label2);
            this.pnlPreviewTop.Controls.Add(this.txtSearchCustomer);
            this.pnlPreviewTop.Controls.Add(this.label1);
            this.pnlPreviewTop.Controls.Add(this.btnDeleteCustomer);
            this.pnlPreviewTop.Controls.Add(this.btnUpdateCustomer);
            this.pnlPreviewTop.Controls.Add(this.btnAddCustomer);
            this.pnlPreviewTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPreviewTop.Name = "pnlPreviewTop";
            this.pnlPreviewTop.Size = new System.Drawing.Size(984, 101);
            this.pnlPreviewTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customers Panel";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(606, 66);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(378, 29);
            this.txtSearchCustomer.TabIndex = 7;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search By Name";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(795, 3);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(186, 55);
            this.btnDeleteCustomer.TabIndex = 5;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(603, 3);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(186, 55);
            this.btnUpdateCustomer.TabIndex = 4;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(411, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(186, 55);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "New";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.cmbGender);
            this.Insert.Controls.Add(this.label7);
            this.Insert.Controls.Add(this.label6);
            this.Insert.Controls.Add(this.label4);
            this.Insert.Controls.Add(this.label3);
            this.Insert.Controls.Add(this.lblInsertCustomer);
            this.Insert.Controls.Add(this.inpPhoneNumber);
            this.Insert.Controls.Add(this.inpEmail);
            this.Insert.Controls.Add(this.inpFullName);
            this.Insert.Controls.Add(this.btnInsertCancel);
            this.Insert.Controls.Add(this.btnInsertCustomer);
            this.Insert.Location = new System.Drawing.Point(4, 31);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(3);
            this.Insert.Size = new System.Drawing.Size(990, 626);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(382, 254);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(385, 30);
            this.cmbGender.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Full Name";
            // 
            // lblInsertCustomer
            // 
            this.lblInsertCustomer.AutoSize = true;
            this.lblInsertCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertCustomer.Location = new System.Drawing.Point(317, 50);
            this.lblInsertCustomer.Name = "lblInsertCustomer";
            this.lblInsertCustomer.Size = new System.Drawing.Size(376, 40);
            this.lblInsertCustomer.TabIndex = 24;
            this.lblInsertCustomer.Text = "Insert New Customer";
            // 
            // inpPhoneNumber
            // 
            this.inpPhoneNumber.Location = new System.Drawing.Point(382, 219);
            this.inpPhoneNumber.Name = "inpPhoneNumber";
            this.inpPhoneNumber.Size = new System.Drawing.Size(385, 29);
            this.inpPhoneNumber.TabIndex = 3;
            // 
            // inpEmail
            // 
            this.inpEmail.Location = new System.Drawing.Point(382, 184);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.Size = new System.Drawing.Size(385, 29);
            this.inpEmail.TabIndex = 2;
            // 
            // inpFullName
            // 
            this.inpFullName.Location = new System.Drawing.Point(382, 149);
            this.inpFullName.Name = "inpFullName";
            this.inpFullName.Size = new System.Drawing.Size(385, 29);
            this.inpFullName.TabIndex = 1;
            // 
            // btnInsertCancel
            // 
            this.btnInsertCancel.Location = new System.Drawing.Point(798, 565);
            this.btnInsertCancel.Name = "btnInsertCancel";
            this.btnInsertCancel.Size = new System.Drawing.Size(186, 55);
            this.btnInsertCancel.TabIndex = 6;
            this.btnInsertCancel.Text = "Cancel";
            this.btnInsertCancel.UseVisualStyleBackColor = true;
            this.btnInsertCancel.Click += new System.EventHandler(this.btnInsertCancel_Click_1);
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Location = new System.Drawing.Point(798, 504);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(186, 55);
            this.btnInsertCustomer.TabIndex = 5;
            this.btnInsertCustomer.Text = "Add Customer";
            this.btnInsertCustomer.UseVisualStyleBackColor = true;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 661);
            this.Controls.Add(this.tbcCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPage";
            this.Text = "CustomerPage";
            this.tbcCustomer.ResumeLayout(false);
            this.Preview.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreviewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlPreviewTop.ResumeLayout(false);
            this.pnlPreviewTop.PerformLayout();
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCustomer;
        private System.Windows.Forms.TabPage Preview;
        private System.Windows.Forms.TabPage Insert;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Panel pnlPreviewTop;
        private System.Windows.Forms.Panel pnlPreviewData;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInsertCustomer;
        private System.Windows.Forms.TextBox inpPhoneNumber;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.TextBox inpFullName;
        private System.Windows.Forms.Button btnInsertCancel;
        private System.Windows.Forms.Button btnInsertCustomer;
    }
}