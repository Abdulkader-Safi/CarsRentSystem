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
    public partial class EmployeesPage : Form
    {

        EmployeeController employeeController;
        int ID;

        public EmployeesPage()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            tbcEmployee.TabPages.Remove(Insert);
            getData();
        }

        public void getData()
        {
            var Employeess = employeeController.GetAll();
            dgvEmployees.DataSource = Employeess;
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == String.Empty)
            {
                getData();
            }
            else
            {
                var Employeess = employeeController.Search(txtSearchEmployee.Text);
                dgvEmployees.DataSource = Employeess;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            tbcEmployee.SelectedTab = Insert;
            tbcEmployee.TabPages.Add(Insert);
            tbcEmployee.TabPages.Remove(Preview);
            btnInsertEmployee.Text = "Add Employee";
            lblInsertEmployee.Text = "Insert New Employee";
        }

        private void btnInsertCancel_Click(object sender, EventArgs e)
        {
            tbcEmployee.TabPages.Add(Preview);
            tbcEmployee.SelectedTab = Preview;
            tbcEmployee.TabPages.Remove(Insert);
            emptyFields();
        }

        private void inpPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inpSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            if (btnInsertEmployee.Text == "Add Employee")
            {
                if (inpFullName.Text == String.Empty || inpEmail.Text == String.Empty ||
                    inpPassword.Text == String.Empty || cmbRole.Text == String.Empty ||
                    inpPhoneNumber.Text == String.Empty || inpSalary.Text == String.Empty)
                {
                    string message = "All Data requied";
                    string title = "";
                    MessageBox.Show(message, title);
                }
                else
                {
                    EmployeeModel Employee = new EmployeeModel(inpFullName.Text, inpEmail.Text, inpPassword.Text,
                                                            cmbRole.Text, Convert.ToInt32(inpPhoneNumber.Text), Convert.ToInt32(inpSalary.Text));
                    employeeController.Add(Employee);

                    emptyFields();

                    tbcEmployee.TabPages.Add(Preview);
                    tbcEmployee.SelectedTab = Preview;
                    tbcEmployee.TabPages.Remove(Insert);

                    getData();
                }
            }
            else if(btnInsertEmployee.Text == "Update Employee")
            {
                if (inpFullName.Text == String.Empty || inpEmail.Text == String.Empty ||
                    inpPassword.Text == String.Empty || cmbRole.Text == String.Empty ||
                    inpPhoneNumber.Text == String.Empty || inpSalary.Text == String.Empty)
                {
                    string message = "All Data requied";
                    string title = "";
                    MessageBox.Show(message, title);
                }
                else
                {
                    EmployeeModel Employee = new EmployeeModel(inpFullName.Text, inpEmail.Text, inpPassword.Text,
                                                            cmbRole.Text, Convert.ToInt32(inpPhoneNumber.Text), Convert.ToInt32(inpSalary.Text));
                    employeeController.Update(Employee, ID);

                    emptyFields();

                    tbcEmployee.TabPages.Add(Preview);
                    tbcEmployee.SelectedTab = Preview;
                    tbcEmployee.TabPages.Remove(Insert);

                    getData();
                }
            }
        }

        public void emptyFields()
        {
            inpFullName.Text = String.Empty;
            inpEmail.Text = String.Empty;
            inpPassword.Text = String.Empty;
            cmbRole.Text = String.Empty;
            inpPhoneNumber.Text = String.Empty;
            inpSalary.Text = String.Empty;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
            {
                ID = Convert.ToInt32(row.Cells[0].Value);

                inpFullName.Text = row.Cells[1].Value.ToString();
                inpEmail.Text = row.Cells[2].Value.ToString();
                inpPassword.Text = row.Cells[3].Value.ToString();
                cmbRole.Text = row.Cells[4].Value.ToString();
                inpPhoneNumber.Text = row.Cells[5].Value.ToString();
                inpSalary.Text = row.Cells[6].Value.ToString();
            }

            tbcEmployee.SelectedTab = Insert;
            tbcEmployee.TabPages.Add(Insert);
            tbcEmployee.TabPages.Remove(Preview);

            btnInsertEmployee.Text = "Update Employee";
            lblInsertEmployee.Text = "Update Employee Info";
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
            {
                ID = Convert.ToInt32(row.Cells[0].Value);
            }
            employeeController.Delete(ID);
            getData();
        }
    }
}
