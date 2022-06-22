using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CarsRentSystem.View;

namespace CarsRentSystem
{
    public partial class CarRentSystem : Form
    {
        public int EmployeeID { get; set; }
        public string employeeName { get; set; }

        public CarRentSystem(int EmployeeID, string employeeName)
        {
            this.EmployeeID = EmployeeID;
            this.employeeName = employeeName;

            InitializeComponent();
            LoadForm(new DashboardPage());
            loadForm();
        }

        public void loadForm()
        {
            btnUser.Text = employeeName;
            btnUser.Enabled = false;
        }

        private void CarRentSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new DashboardPage());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            LoadForm(new EmployeesPage());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerPage());
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            LoadForm(new CarsPage());
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            LoadForm(new RentPage(EmployeeID, employeeName));
        }

        void LoadForm(Form form)
        {
            form.TopLevel = false;
            pnlView.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Close application", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }

        }   
    }
}
