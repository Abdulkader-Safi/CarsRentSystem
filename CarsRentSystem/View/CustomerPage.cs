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
    public partial class CustomerPage : Form
    {
        CustomerController customerController;
        int ID;

        public CustomerPage()
        {
            InitializeComponent();
            customerController = new CustomerController();
            tbcCustomer.TabPages.Remove(Insert);
            getData();
        }

        public void getData()
        {
            var Customers = customerController.GetAll();
            dgvCustomers.DataSource = Customers;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            tbcCustomer.SelectedTab = Insert;
            tbcCustomer.TabPages.Add(Insert);
            tbcCustomer.TabPages.Remove(Preview);
            btnInsertCustomer.Text = "Add Customer";
            lblInsertCustomer.Text = "Insert New Customer";
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == String.Empty)
            {
                getData();
            }
            else
            {
                var Employeess = customerController.Search(txtSearchCustomer.Text);
                dgvCustomers.DataSource = Employeess;
            }
        }

        private void btnInsertCancel_Click_1(object sender, EventArgs e)
        {
            tbcCustomer.TabPages.Add(Preview);
            tbcCustomer.SelectedTab = Preview;
            tbcCustomer.TabPages.Remove(Insert);
            emptyFields();
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            if (btnInsertCustomer.Text == "Add Customer")
            {
                if (inpFullName.Text == String.Empty || inpEmail.Text == String.Empty ||
                    inpPhoneNumber.Text == String.Empty || cmbGender.Text == String.Empty)
                {
                    string message = "All Data requied";
                    string title = "";
                    MessageBox.Show(message, title);
                }
                else
                {
                    CustomerModel Customer = new CustomerModel(inpFullName.Text, inpEmail.Text,
                                                            Convert.ToInt32(inpPhoneNumber.Text), cmbGender.Text);

                    customerController.Add(Customer);

                    emptyFields();

                    tbcCustomer.TabPages.Add(Preview);
                    tbcCustomer.SelectedTab = Preview;
                    tbcCustomer.TabPages.Remove(Insert);

                    getData();
                }
            }
            else if (btnInsertCustomer.Text == "Update Customer")
            {
                if (inpFullName.Text == String.Empty || inpEmail.Text == String.Empty ||
                    inpPhoneNumber.Text == String.Empty || cmbGender.Text == String.Empty)
                {
                    string message = "All Data requied";
                    string title = "";
                    MessageBox.Show(message, title);
                }
                else
                {
                    CustomerModel Customer = new CustomerModel(inpFullName.Text, inpEmail.Text,
                                                            Convert.ToInt32(inpPhoneNumber.Text), cmbGender.Text);

                    customerController.Update(Customer, ID);

                    emptyFields();

                    tbcCustomer.TabPages.Add(Preview);
                    tbcCustomer.SelectedTab = Preview;
                    tbcCustomer.TabPages.Remove(Insert);

                    getData();
                }
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomers.SelectedRows)
            {
                ID = Convert.ToInt32(row.Cells[0].Value);

                inpFullName.Text = row.Cells[1].Value.ToString();
                inpEmail.Text = row.Cells[2].Value.ToString();
                inpPhoneNumber.Text = row.Cells[3].Value.ToString();
                cmbGender.Text = row.Cells[4].Value.ToString();
            }

            tbcCustomer.SelectedTab = Insert;
            tbcCustomer.TabPages.Add(Insert);
            tbcCustomer.TabPages.Remove(Preview);

            btnInsertCustomer.Text = "Update Customer";
            lblInsertCustomer.Text = "Update Employee Info";
        }

        public void emptyFields()
        {
            inpFullName.Text = String.Empty;
            inpEmail.Text = String.Empty;
            inpPhoneNumber.Text = String.Empty;
            cmbGender.Text = String.Empty;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomers.SelectedRows)
            {
                ID = Convert.ToInt32(row.Cells[0].Value);
            }
            customerController.Delete(ID);
            getData();
        }
    }
}
