namespace CarsRentSystem.View
{
    partial class DashboardPage
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
            this.btnCustomerCount = new System.Windows.Forms.Button();
            this.btnInUseCar = new System.Windows.Forms.Button();
            this.btnAvaliableCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerCount
            // 
            this.btnCustomerCount.Location = new System.Drawing.Point(64, 220);
            this.btnCustomerCount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCustomerCount.Name = "btnCustomerCount";
            this.btnCustomerCount.Size = new System.Drawing.Size(239, 130);
            this.btnCustomerCount.TabIndex = 0;
            this.btnCustomerCount.Text = "button1";
            this.btnCustomerCount.UseVisualStyleBackColor = true;
            // 
            // btnInUseCar
            // 
            this.btnInUseCar.Location = new System.Drawing.Point(702, 220);
            this.btnInUseCar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnInUseCar.Name = "btnInUseCar";
            this.btnInUseCar.Size = new System.Drawing.Size(239, 130);
            this.btnInUseCar.TabIndex = 2;
            this.btnInUseCar.Text = "button3";
            this.btnInUseCar.UseVisualStyleBackColor = true;
            // 
            // btnAvaliableCar
            // 
            this.btnAvaliableCar.Location = new System.Drawing.Point(381, 220);
            this.btnAvaliableCar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAvaliableCar.Name = "btnAvaliableCar";
            this.btnAvaliableCar.Size = new System.Drawing.Size(239, 130);
            this.btnAvaliableCar.TabIndex = 1;
            this.btnAvaliableCar.Text = "button2";
            this.btnAvaliableCar.UseVisualStyleBackColor = true;
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 661);
            this.Controls.Add(this.btnInUseCar);
            this.Controls.Add(this.btnAvaliableCar);
            this.Controls.Add(this.btnCustomerCount);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DashboardPage";
            this.Text = "DashboardPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerCount;
        private System.Windows.Forms.Button btnInUseCar;
        private System.Windows.Forms.Button btnAvaliableCar;
    }
}