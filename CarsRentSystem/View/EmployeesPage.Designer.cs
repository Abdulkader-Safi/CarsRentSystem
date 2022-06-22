namespace CarsRentSystem.View
{
    partial class EmployeesPage
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
            this.tbcEmployee = new System.Windows.Forms.TabControl();
            this.Preview = new System.Windows.Forms.TabPage();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.pnlPreviewData = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pnlPerviewTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.TabPage();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInsertEmployee = new System.Windows.Forms.Label();
            this.inpSalary = new System.Windows.Forms.TextBox();
            this.inpPhoneNumber = new System.Windows.Forms.TextBox();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.inpFullName = new System.Windows.Forms.TextBox();
            this.btnInsertCancel = new System.Windows.Forms.Button();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.tbcEmployee.SuspendLayout();
            this.Preview.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.pnlPreviewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlPerviewTop.SuspendLayout();
            this.Insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEmployee
            // 
            this.tbcEmployee.Controls.Add(this.Preview);
            this.tbcEmployee.Controls.Add(this.Insert);
            this.tbcEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.tbcEmployee.Location = new System.Drawing.Point(0, 0);
            this.tbcEmployee.Name = "tbcEmployee";
            this.tbcEmployee.SelectedIndex = 0;
            this.tbcEmployee.Size = new System.Drawing.Size(998, 661);
            this.tbcEmployee.TabIndex = 0;
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
            this.pnlPreview.Controls.Add(this.pnlPerviewTop);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Location = new System.Drawing.Point(3, 3);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(984, 620);
            this.pnlPreview.TabIndex = 0;
            // 
            // pnlPreviewData
            // 
            this.pnlPreviewData.Controls.Add(this.dgvEmployees);
            this.pnlPreviewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreviewData.Location = new System.Drawing.Point(0, 101);
            this.pnlPreviewData.Name = "pnlPreviewData";
            this.pnlPreviewData.Size = new System.Drawing.Size(984, 519);
            this.pnlPreviewData.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(984, 519);
            this.dgvEmployees.TabIndex = 0;
            // 
            // pnlPerviewTop
            // 
            this.pnlPerviewTop.Controls.Add(this.label2);
            this.pnlPerviewTop.Controls.Add(this.txtSearchEmployee);
            this.pnlPerviewTop.Controls.Add(this.label1);
            this.pnlPerviewTop.Controls.Add(this.btnDeleteEmployee);
            this.pnlPerviewTop.Controls.Add(this.btnUpdateEmployee);
            this.pnlPerviewTop.Controls.Add(this.btnAddEmployee);
            this.pnlPerviewTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPerviewTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPerviewTop.Name = "pnlPerviewTop";
            this.pnlPerviewTop.Size = new System.Drawing.Size(984, 101);
            this.pnlPerviewTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Panel";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(606, 64);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(378, 29);
            this.txtSearchEmployee.TabIndex = 4;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Name";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(795, 3);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(186, 55);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(603, 3);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(186, 55);
            this.btnUpdateEmployee.TabIndex = 1;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(411, 3);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(186, 55);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "New";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.cmbRole);
            this.Insert.Controls.Add(this.label8);
            this.Insert.Controls.Add(this.label7);
            this.Insert.Controls.Add(this.label6);
            this.Insert.Controls.Add(this.label5);
            this.Insert.Controls.Add(this.label4);
            this.Insert.Controls.Add(this.label3);
            this.Insert.Controls.Add(this.lblInsertEmployee);
            this.Insert.Controls.Add(this.inpSalary);
            this.Insert.Controls.Add(this.inpPhoneNumber);
            this.Insert.Controls.Add(this.inpPassword);
            this.Insert.Controls.Add(this.inpEmail);
            this.Insert.Controls.Add(this.inpFullName);
            this.Insert.Controls.Add(this.btnInsertCancel);
            this.Insert.Controls.Add(this.btnInsertEmployee);
            this.Insert.Location = new System.Drawing.Point(4, 31);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(3);
            this.Insert.Size = new System.Drawing.Size(990, 626);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Managar",
            "Agent"});
            this.cmbRole.Location = new System.Drawing.Point(382, 254);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(385, 30);
            this.cmbRole.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full Name";
            // 
            // lblInsertEmployee
            // 
            this.lblInsertEmployee.AutoSize = true;
            this.lblInsertEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertEmployee.Location = new System.Drawing.Point(317, 50);
            this.lblInsertEmployee.Name = "lblInsertEmployee";
            this.lblInsertEmployee.Size = new System.Drawing.Size(377, 40);
            this.lblInsertEmployee.TabIndex = 9;
            this.lblInsertEmployee.Text = "Insert New Employee";
            // 
            // inpSalary
            // 
            this.inpSalary.Location = new System.Drawing.Point(382, 325);
            this.inpSalary.Name = "inpSalary";
            this.inpSalary.Size = new System.Drawing.Size(385, 29);
            this.inpSalary.TabIndex = 6;
            this.inpSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpSalary_KeyPress);
            // 
            // inpPhoneNumber
            // 
            this.inpPhoneNumber.Location = new System.Drawing.Point(382, 290);
            this.inpPhoneNumber.Name = "inpPhoneNumber";
            this.inpPhoneNumber.Size = new System.Drawing.Size(385, 29);
            this.inpPhoneNumber.TabIndex = 5;
            this.inpPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpPhoneNumber_KeyPress);
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(382, 219);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(385, 29);
            this.inpPassword.TabIndex = 3;
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
            this.btnInsertCancel.TabIndex = 8;
            this.btnInsertCancel.Text = "Cancel";
            this.btnInsertCancel.UseVisualStyleBackColor = true;
            this.btnInsertCancel.Click += new System.EventHandler(this.btnInsertCancel_Click);
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Location = new System.Drawing.Point(798, 504);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(186, 55);
            this.btnInsertEmployee.TabIndex = 7;
            this.btnInsertEmployee.Text = "Add Account";
            this.btnInsertEmployee.UseVisualStyleBackColor = true;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click);
            // 
            // EmployeesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 661);
            this.Controls.Add(this.tbcEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesPage";
            this.Text = "EmployeesPage";
            this.tbcEmployee.ResumeLayout(false);
            this.Preview.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreviewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlPerviewTop.ResumeLayout(false);
            this.pnlPerviewTop.PerformLayout();
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEmployee;
        private System.Windows.Forms.TabPage Preview;
        private System.Windows.Forms.TabPage Insert;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Panel pnlPerviewTop;
        private System.Windows.Forms.Panel pnlPreviewData;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertCancel;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.TextBox inpSalary;
        private System.Windows.Forms.TextBox inpPhoneNumber;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.TextBox inpFullName;
        private System.Windows.Forms.Label lblInsertEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}