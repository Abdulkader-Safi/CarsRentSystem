namespace CarsRentSystem.View
{
    partial class CarsPage
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
            this.tbcCar = new System.Windows.Forms.TabControl();
            this.Preview = new System.Windows.Forms.TabPage();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.pnlPreviewData = new System.Windows.Forms.Panel();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.pnlPreviewTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.inpYOM = new System.Windows.Forms.TextBox();
            this.cmbTransmission = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFual = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInsertCar = new System.Windows.Forms.Label();
            this.inpCapacity = new System.Windows.Forms.TextBox();
            this.inpColor = new System.Windows.Forms.TextBox();
            this.inpDHP = new System.Windows.Forms.TextBox();
            this.inpRegistration = new System.Windows.Forms.TextBox();
            this.inpModel = new System.Windows.Forms.TextBox();
            this.btnInsertCancel = new System.Windows.Forms.Button();
            this.btnInsertCar = new System.Windows.Forms.Button();
            this.tbcCar.SuspendLayout();
            this.Preview.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.pnlPreviewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.pnlPreviewTop.SuspendLayout();
            this.Insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCar
            // 
            this.tbcCar.Controls.Add(this.Preview);
            this.tbcCar.Controls.Add(this.Insert);
            this.tbcCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.tbcCar.Location = new System.Drawing.Point(0, 0);
            this.tbcCar.Name = "tbcCar";
            this.tbcCar.SelectedIndex = 0;
            this.tbcCar.Size = new System.Drawing.Size(998, 661);
            this.tbcCar.TabIndex = 0;
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
            this.pnlPreviewData.Controls.Add(this.dgvCars);
            this.pnlPreviewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreviewData.Location = new System.Drawing.Point(0, 101);
            this.pnlPreviewData.Name = "pnlPreviewData";
            this.pnlPreviewData.Size = new System.Drawing.Size(984, 519);
            this.pnlPreviewData.TabIndex = 1;
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.Location = new System.Drawing.Point(0, 0);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(984, 519);
            this.dgvCars.TabIndex = 0;
            // 
            // pnlPreviewTop
            // 
            this.pnlPreviewTop.Controls.Add(this.label2);
            this.pnlPreviewTop.Controls.Add(this.txtSearchCar);
            this.pnlPreviewTop.Controls.Add(this.label1);
            this.pnlPreviewTop.Controls.Add(this.btnDeleteCar);
            this.pnlPreviewTop.Controls.Add(this.btnUpdateCar);
            this.pnlPreviewTop.Controls.Add(this.btnAddCar);
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
            this.label2.Location = new System.Drawing.Point(72, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Car Panel";
            // 
            // txtSearchCar
            // 
            this.txtSearchCar.Location = new System.Drawing.Point(603, 64);
            this.txtSearchCar.Name = "txtSearchCar";
            this.txtSearchCar.Size = new System.Drawing.Size(378, 29);
            this.txtSearchCar.TabIndex = 10;
            this.txtSearchCar.TextChanged += new System.EventHandler(this.txtSearchCar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search By Name";
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(795, 3);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(186, 55);
            this.btnDeleteCar.TabIndex = 8;
            this.btnDeleteCar.Text = "Delete";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(603, 3);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(186, 55);
            this.btnUpdateCar.TabIndex = 7;
            this.btnUpdateCar.Text = "Update";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(411, 3);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(186, 55);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "New";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.label11);
            this.Insert.Controls.Add(this.inpYOM);
            this.Insert.Controls.Add(this.cmbTransmission);
            this.Insert.Controls.Add(this.label9);
            this.Insert.Controls.Add(this.cmbFual);
            this.Insert.Controls.Add(this.label8);
            this.Insert.Controls.Add(this.label7);
            this.Insert.Controls.Add(this.label6);
            this.Insert.Controls.Add(this.label5);
            this.Insert.Controls.Add(this.label4);
            this.Insert.Controls.Add(this.label3);
            this.Insert.Controls.Add(this.lblInsertCar);
            this.Insert.Controls.Add(this.inpCapacity);
            this.Insert.Controls.Add(this.inpColor);
            this.Insert.Controls.Add(this.inpDHP);
            this.Insert.Controls.Add(this.inpRegistration);
            this.Insert.Controls.Add(this.inpModel);
            this.Insert.Controls.Add(this.btnInsertCancel);
            this.Insert.Controls.Add(this.btnInsertCar);
            this.Insert.Location = new System.Drawing.Point(4, 31);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(3);
            this.Insert.Size = new System.Drawing.Size(990, 626);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Year Of Model";
            // 
            // inpYOM
            // 
            this.inpYOM.Location = new System.Drawing.Point(382, 255);
            this.inpYOM.Name = "inpYOM";
            this.inpYOM.Size = new System.Drawing.Size(385, 29);
            this.inpYOM.TabIndex = 35;
            this.inpYOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpYOM_KeyPress);
            // 
            // cmbTransmission
            // 
            this.cmbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransmission.FormattingEnabled = true;
            this.cmbTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.cmbTransmission.Location = new System.Drawing.Point(382, 396);
            this.cmbTransmission.Name = "cmbTransmission";
            this.cmbTransmission.Size = new System.Drawing.Size(385, 30);
            this.cmbTransmission.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Transmission";
            // 
            // cmbFual
            // 
            this.cmbFual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFual.FormattingEnabled = true;
            this.cmbFual.Items.AddRange(new object[] {
            "Electric",
            "Gas"});
            this.cmbFual.Location = new System.Drawing.Point(382, 360);
            this.cmbFual.Name = "cmbFual";
            this.cmbFual.Size = new System.Drawing.Size(385, 30);
            this.cmbFual.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Daily Hire Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Model";
            // 
            // lblInsertCar
            // 
            this.lblInsertCar.AutoSize = true;
            this.lblInsertCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertCar.Location = new System.Drawing.Point(317, 50);
            this.lblInsertCar.Name = "lblInsertCar";
            this.lblInsertCar.Size = new System.Drawing.Size(272, 40);
            this.lblInsertCar.TabIndex = 24;
            this.lblInsertCar.Text = "Insert New Car";
            // 
            // inpCapacity
            // 
            this.inpCapacity.Location = new System.Drawing.Point(382, 325);
            this.inpCapacity.Name = "inpCapacity";
            this.inpCapacity.Size = new System.Drawing.Size(385, 29);
            this.inpCapacity.TabIndex = 21;
            this.inpCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpCapacity_KeyPress);
            // 
            // inpColor
            // 
            this.inpColor.Location = new System.Drawing.Point(382, 290);
            this.inpColor.Name = "inpColor";
            this.inpColor.Size = new System.Drawing.Size(385, 29);
            this.inpColor.TabIndex = 20;
            // 
            // inpDHP
            // 
            this.inpDHP.Location = new System.Drawing.Point(382, 219);
            this.inpDHP.Name = "inpDHP";
            this.inpDHP.Size = new System.Drawing.Size(385, 29);
            this.inpDHP.TabIndex = 18;
            this.inpDHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpDHP_KeyPress);
            // 
            // inpRegistration
            // 
            this.inpRegistration.Location = new System.Drawing.Point(382, 184);
            this.inpRegistration.Name = "inpRegistration";
            this.inpRegistration.Size = new System.Drawing.Size(385, 29);
            this.inpRegistration.TabIndex = 17;
            // 
            // inpModel
            // 
            this.inpModel.Location = new System.Drawing.Point(382, 149);
            this.inpModel.Name = "inpModel";
            this.inpModel.Size = new System.Drawing.Size(385, 29);
            this.inpModel.TabIndex = 16;
            // 
            // btnInsertCancel
            // 
            this.btnInsertCancel.Location = new System.Drawing.Point(798, 565);
            this.btnInsertCancel.Name = "btnInsertCancel";
            this.btnInsertCancel.Size = new System.Drawing.Size(186, 55);
            this.btnInsertCancel.TabIndex = 23;
            this.btnInsertCancel.Text = "Cancel";
            this.btnInsertCancel.UseVisualStyleBackColor = true;
            this.btnInsertCancel.Click += new System.EventHandler(this.btnInsertCancel_Click);
            // 
            // btnInsertCar
            // 
            this.btnInsertCar.Location = new System.Drawing.Point(798, 504);
            this.btnInsertCar.Name = "btnInsertCar";
            this.btnInsertCar.Size = new System.Drawing.Size(186, 55);
            this.btnInsertCar.TabIndex = 22;
            this.btnInsertCar.Text = "Add Car";
            this.btnInsertCar.UseVisualStyleBackColor = true;
            this.btnInsertCar.Click += new System.EventHandler(this.btnInsertCar_Click);
            // 
            // CarsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 661);
            this.Controls.Add(this.tbcCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsPage";
            this.Text = "CarsPage";
            this.tbcCar.ResumeLayout(false);
            this.Preview.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreviewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.pnlPreviewTop.ResumeLayout(false);
            this.pnlPreviewTop.PerformLayout();
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCar;
        private System.Windows.Forms.TabPage Preview;
        private System.Windows.Forms.TabPage Insert;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Panel pnlPreviewTop;
        private System.Windows.Forms.Panel pnlPreviewData;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.ComboBox cmbFual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInsertCar;
        private System.Windows.Forms.TextBox inpCapacity;
        private System.Windows.Forms.TextBox inpColor;
        private System.Windows.Forms.TextBox inpDHP;
        private System.Windows.Forms.TextBox inpRegistration;
        private System.Windows.Forms.TextBox inpModel;
        private System.Windows.Forms.Button btnInsertCancel;
        private System.Windows.Forms.Button btnInsertCar;
        private System.Windows.Forms.ComboBox cmbTransmission;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inpYOM;
    }
}