namespace CarsRentSystem.View
{
    partial class RentPage
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
            this.tbcRent = new System.Windows.Forms.TabControl();
            this.Preview = new System.Windows.Forms.TabPage();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.pnlPreviewData = new System.Windows.Forms.Panel();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.pnlPreviewTop = new System.Windows.Forms.Panel();
            this.btnAllRent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnAddRent = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.TabPage();
            this.cbxRentCost = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblInsertCar = new System.Windows.Forms.Label();
            this.inpRentCost = new System.Windows.Forms.TextBox();
            this.btnInsertCancel = new System.Windows.Forms.Button();
            this.btnInsertRent = new System.Windows.Forms.Button();
            this.tbcRent.SuspendLayout();
            this.Preview.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.pnlPreviewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.pnlPreviewTop.SuspendLayout();
            this.Insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRent
            // 
            this.tbcRent.Controls.Add(this.Preview);
            this.tbcRent.Controls.Add(this.Insert);
            this.tbcRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.tbcRent.Location = new System.Drawing.Point(0, 0);
            this.tbcRent.Name = "tbcRent";
            this.tbcRent.SelectedIndex = 0;
            this.tbcRent.Size = new System.Drawing.Size(998, 661);
            this.tbcRent.TabIndex = 0;
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
            this.pnlPreviewData.Controls.Add(this.dgvRent);
            this.pnlPreviewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreviewData.Location = new System.Drawing.Point(0, 101);
            this.pnlPreviewData.Name = "pnlPreviewData";
            this.pnlPreviewData.Size = new System.Drawing.Size(984, 519);
            this.pnlPreviewData.TabIndex = 1;
            // 
            // dgvRent
            // 
            this.dgvRent.AllowUserToAddRows = false;
            this.dgvRent.AllowUserToDeleteRows = false;
            this.dgvRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRent.Location = new System.Drawing.Point(0, 0);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.ReadOnly = true;
            this.dgvRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRent.Size = new System.Drawing.Size(984, 519);
            this.dgvRent.TabIndex = 0;
            // 
            // pnlPreviewTop
            // 
            this.pnlPreviewTop.Controls.Add(this.btnAllRent);
            this.pnlPreviewTop.Controls.Add(this.label2);
            this.pnlPreviewTop.Controls.Add(this.btnReturnCar);
            this.pnlPreviewTop.Controls.Add(this.btnAddRent);
            this.pnlPreviewTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPreviewTop.Name = "pnlPreviewTop";
            this.pnlPreviewTop.Size = new System.Drawing.Size(984, 101);
            this.pnlPreviewTop.TabIndex = 0;
            // 
            // btnAllRent
            // 
            this.btnAllRent.Location = new System.Drawing.Point(795, 3);
            this.btnAllRent.Name = "btnAllRent";
            this.btnAllRent.Size = new System.Drawing.Size(186, 55);
            this.btnAllRent.TabIndex = 24;
            this.btnAllRent.Text = "All Rent";
            this.btnAllRent.UseVisualStyleBackColor = true;
            this.btnAllRent.Click += new System.EventHandler(this.btnAllRent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rent Panel";
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(603, 3);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(186, 55);
            this.btnReturnCar.TabIndex = 16;
            this.btnReturnCar.Text = "Return";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnAddRent
            // 
            this.btnAddRent.Location = new System.Drawing.Point(411, 3);
            this.btnAddRent.Name = "btnAddRent";
            this.btnAddRent.Size = new System.Drawing.Size(186, 55);
            this.btnAddRent.TabIndex = 15;
            this.btnAddRent.Text = "New";
            this.btnAddRent.UseVisualStyleBackColor = true;
            this.btnAddRent.Click += new System.EventHandler(this.btnAddRent_Click);
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.cbxRentCost);
            this.Insert.Controls.Add(this.dtpEndDate);
            this.Insert.Controls.Add(this.dtpStartDate);
            this.Insert.Controls.Add(this.cmbCar);
            this.Insert.Controls.Add(this.label10);
            this.Insert.Controls.Add(this.cmbCustomer);
            this.Insert.Controls.Add(this.label7);
            this.Insert.Controls.Add(this.label6);
            this.Insert.Controls.Add(this.label4);
            this.Insert.Controls.Add(this.label12);
            this.Insert.Controls.Add(this.lblInsertCar);
            this.Insert.Controls.Add(this.inpRentCost);
            this.Insert.Controls.Add(this.btnInsertCancel);
            this.Insert.Controls.Add(this.btnInsertRent);
            this.Insert.Location = new System.Drawing.Point(4, 31);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(3);
            this.Insert.Size = new System.Drawing.Size(990, 626);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // cbxRentCost
            // 
            this.cbxRentCost.AutoSize = true;
            this.cbxRentCost.Location = new System.Drawing.Point(409, 324);
            this.cbxRentCost.Name = "cbxRentCost";
            this.cbxRentCost.Size = new System.Drawing.Size(324, 26);
            this.cbxRentCost.TabIndex = 60;
            this.cbxRentCost.Text = "Calculate Rent Cost Automaticly";
            this.cbxRentCost.UseVisualStyleBackColor = true;
            this.cbxRentCost.CheckedChanged += new System.EventHandler(this.cbxRentCost_CheckedChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(382, 254);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(385, 29);
            this.dtpEndDate.TabIndex = 59;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(382, 220);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(385, 29);
            this.dtpStartDate.TabIndex = 58;
            // 
            // cmbCar
            // 
            this.cmbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(382, 184);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(385, 30);
            this.cmbCar.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 55;
            this.label10.Text = "Rent Cost";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(382, 149);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(385, 30);
            this.cmbCustomer.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Car ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 22);
            this.label12.TabIndex = 48;
            this.label12.Text = "Customer ID";
            // 
            // lblInsertCar
            // 
            this.lblInsertCar.AutoSize = true;
            this.lblInsertCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertCar.Location = new System.Drawing.Point(317, 50);
            this.lblInsertCar.Name = "lblInsertCar";
            this.lblInsertCar.Size = new System.Drawing.Size(272, 40);
            this.lblInsertCar.TabIndex = 47;
            this.lblInsertCar.Text = "Insert New Car";
            // 
            // inpRentCost
            // 
            this.inpRentCost.Location = new System.Drawing.Point(382, 289);
            this.inpRentCost.Name = "inpRentCost";
            this.inpRentCost.Size = new System.Drawing.Size(385, 29);
            this.inpRentCost.TabIndex = 37;
            this.inpRentCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpRegistration_KeyPress);
            // 
            // btnInsertCancel
            // 
            this.btnInsertCancel.Location = new System.Drawing.Point(798, 565);
            this.btnInsertCancel.Name = "btnInsertCancel";
            this.btnInsertCancel.Size = new System.Drawing.Size(186, 55);
            this.btnInsertCancel.TabIndex = 46;
            this.btnInsertCancel.Text = "Cancel";
            this.btnInsertCancel.UseVisualStyleBackColor = true;
            this.btnInsertCancel.Click += new System.EventHandler(this.btnInsertCancel_Click);
            // 
            // btnInsertRent
            // 
            this.btnInsertRent.Location = new System.Drawing.Point(798, 504);
            this.btnInsertRent.Name = "btnInsertRent";
            this.btnInsertRent.Size = new System.Drawing.Size(186, 55);
            this.btnInsertRent.TabIndex = 45;
            this.btnInsertRent.Text = "Add Rent";
            this.btnInsertRent.UseVisualStyleBackColor = true;
            this.btnInsertRent.Click += new System.EventHandler(this.btnInsertRent_Click);
            // 
            // RentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 661);
            this.Controls.Add(this.tbcRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentPage";
            this.Text = "RentPage";
            this.tbcRent.ResumeLayout(false);
            this.Preview.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreviewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.pnlPreviewTop.ResumeLayout(false);
            this.pnlPreviewTop.PerformLayout();
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRent;
        private System.Windows.Forms.TabPage Preview;
        private System.Windows.Forms.TabPage Insert;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Panel pnlPreviewTop;
        private System.Windows.Forms.Panel pnlPreviewData;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Button btnAddRent;
        private System.Windows.Forms.Button btnAllRent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInsertCar;
        private System.Windows.Forms.TextBox inpRentCost;
        private System.Windows.Forms.Button btnInsertCancel;
        private System.Windows.Forms.Button btnInsertRent;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.CheckBox cbxRentCost;
    }
}