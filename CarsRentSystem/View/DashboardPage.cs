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

namespace CarsRentSystem.View
{
    public partial class DashboardPage : Form
    {
        CarController carController;
        CustomerController customerController;

        public DashboardPage()
        {
            InitializeComponent();
            carController = new CarController();
            customerController = new CustomerController();
            startup();
        }

        public void startup()
        {
            int inUse = carController.TotalCarUsed();
            int Avaliable = carController.TotalCarAvaliable();
            int customer = customerController.TotalCustomer();
            btnCustomerCount.Enabled = false;
            btnAvaliableCar.Enabled = false;
            btnInUseCar.Enabled = false;

            btnInUseCar.Text = "In Use Car \n\t " + inUse;
            btnAvaliableCar.Text = "Avaliable Car \n\t " + Avaliable;
            btnCustomerCount.Text = "Customer Count \n\t " + customer;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            startup();
        }
    }
}
