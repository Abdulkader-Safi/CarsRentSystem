using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CarsRentSystem.Models;
using CarsRentSystem.Controller;

namespace CarsRentSystem
{
    public partial class LogIn : Form
    {
        EmployeeController employeeController;

        public LogIn()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = inpLoginEmail.Text;
            string password = inpLoginPassword.Text;
            string[] account = employeeController.Login(email, password);

            if (account[0] == "True")
            {
                int ID = Convert.ToInt32(account[1]);
                string FullName = account[2];
                
                CarRentSystem carRentSystem = new CarRentSystem(ID, FullName);
                carRentSystem.Show();
                this.Hide();
            }
            else if (account[0] == "False")
            {
                MessageBox.Show(account[1]);
            }
            else
            {
                MessageBox.Show("Enter your account mail and password");
            }
        }

    }
}
