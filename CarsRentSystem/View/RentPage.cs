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
    public partial class RentPage : Form
    {
        RentController rentController;
        int ID;

        public int EmployeeID { get; set; }
        public string employeeName { get; set; }

        public RentPage(int EmployeeID, string employeeName)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;
            this.employeeName = employeeName;

            rentController = new RentController();
            tbcRent.TabPages.Remove(Insert);
            getData();
            getComboData();
        }

        public void getData()
        {
            var Rents = rentController.GetAll();
            dgvRent.DataSource = Rents;

            cbxRentCost.Checked = false;
            inpRentCost.Enabled = true;
        }

        private void btnAllRent_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void inpRegistration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void getComboData()
        {
            string carDate = "";
            CarController cars = new CarController();
            foreach (CarModel car in cars.GetAll())
            {
                if(car.status == "Avaliable")
                {
                    carDate = car.ID + "-" + car.model + "-" + car.dailyHirePrice + " $";
                    cmbCar.Items.Add(carDate);
                }
            }

            string customerDate = "";
            CustomerController Customers = new CustomerController();
            foreach (CustomerModel Customer in Customers.GetAll())
            {
                customerDate = Customer.ID + "-" + Customer.fullName;
                cmbCustomer.Items.Add(customerDate);
            }
        }

        private void cbxRentCost_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxRentCost.Checked)
            {
                if(cmbCar.Text != String.Empty)
                {
                    string getCarDetails = cmbCar.Text;
                    string[] getCarDetails2 = getCarDetails.Split('-');
                    string[] getCarDetails3 = getCarDetails2[2].Split(' ');
                    int dailyPrice = Convert.ToInt32(getCarDetails3[0]);

                    DateTime startDate = dtpStartDate.Value.Date;
                    DateTime endDate = dtpEndDate.Value.Date;
                    TimeSpan difference = endDate.Subtract(startDate);
                    var days = (endDate - startDate).TotalDays;

                    int rentCost = (int)days * dailyPrice;

                    inpRentCost.Enabled = false;
                    inpRentCost.Text = rentCost.ToString();

                }
                else
                {
                    MessageBox.Show("Select a car First");
                }
            }
            else
            {
                inpRentCost.Enabled = true;
            }
        }

        private void btnAddRent_Click(object sender, EventArgs e)
        {
            tbcRent.SelectedTab = Insert;
            tbcRent.TabPages.Add(Insert);
            tbcRent.TabPages.Remove(Preview);
            
        }

        private void btnInsertRent_Click(object sender, EventArgs e)
        {
            if (cmbCar.Text == String.Empty || cmbCustomer.Text == String.Empty ||
                inpRentCost.Text == String.Empty)
            {
                string message = "All Data requied";
                string title = "";
                MessageBox.Show(message, title);
            }
            else
            {
                string getCustomerDetails = cmbCustomer.Text;
                string[] getCustomerDetails2 = getCustomerDetails.Split('-');
                int customerID = Convert.ToInt32(getCustomerDetails2[0]);

                string getCarDetails = cmbCar.Text;
                string[] getCarDetails2 = getCarDetails.Split('-');
                int CarID = Convert.ToInt32(getCarDetails2[0]);

                RentModel Rent = new RentModel(customerID, CarID, EmployeeID, dtpStartDate.Value, 
                                                dtpEndDate.Value, Convert.ToInt32(inpRentCost.Text), "In Use");

                rentController.Add(Rent);

                CarController carController = new CarController();
                carController.InUse(true, CarID);

                emptyFields();

                tbcRent.TabPages.Add(Preview);
                tbcRent.SelectedTab = Preview;
                tbcRent.TabPages.Remove(Insert);

                getData();
            }
        }

        private void btnInsertCancel_Click(object sender, EventArgs e)
        {
            tbcRent.TabPages.Add(Preview);
            tbcRent.SelectedTab = Preview;
            tbcRent.TabPages.Remove(Insert);
            emptyFields();
        }

        public void emptyFields()
        {
            cmbCar.Text = String.Empty;
            cmbCustomer.Text = String.Empty;
            inpRentCost.Text = String.Empty;
            cbxRentCost.Checked = false;
            inpRentCost.Enabled = true;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            DialogResult returnBool = MessageBox.Show("Return Car",
                                  "", MessageBoxButtons.YesNo);
            int CarID;
            if(returnBool == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvRent.SelectedRows)
                {
                    ID = Convert.ToInt32(row.Cells[0].Value);
                    CarID = Convert.ToInt32(row.Cells[2].Value);

                    rentController.Return(ID);
                    CarController carController = new CarController();
                    carController.InUse(false, CarID);
                }
                getData();
            }
        }
    }
}
