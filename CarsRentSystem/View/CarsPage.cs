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
    public partial class CarsPage : Form
    {
        CarController carController;
        int ID;

        public CarsPage()
        {
            InitializeComponent();
            carController = new CarController();
            tbcCar.TabPages.Remove(Insert);
            getData();
        }

        public void getData()
        {
            var Cars = carController.GetAll();
            dgvCars.DataSource = Cars;
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCars.SelectedRows)
            {
                ID = Convert.ToInt32(row.Cells[0].Value);
            }
            carController.Delete(ID);
            getData();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            tbcCar.SelectedTab = Insert;
            tbcCar.TabPages.Add(Insert);
            tbcCar.TabPages.Remove(Preview);
            btnInsertCar.Text = "Add Car";
            lblInsertCar.Text = "Insert New Car";
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCars.SelectedRows)
            {
                ID = Convert.ToInt32(row.Cells[0].Value);

                inpModel.Text = row.Cells[1].Value.ToString();
                inpRegistration.Text = row.Cells[2].Value.ToString();
                inpDHP.Text = row.Cells[3].Value.ToString();
                inpYOM.Text = row.Cells[4].Value.ToString();
                inpColor.Text = row.Cells[5].Value.ToString();
                inpCapacity.Text = row.Cells[6].Value.ToString();
                cmbTransmission.Text = row.Cells[7].Value.ToString();
                cmbFual.Text = row.Cells[8].Value.ToString();
            }

            tbcCar.SelectedTab = Insert;
            tbcCar.TabPages.Add(Insert);
            tbcCar.TabPages.Remove(Preview);

            btnInsertCar.Text = "Update Car";
            lblInsertCar.Text = "Update Car info";
        }

        private void btnInsertCar_Click(object sender, EventArgs e)
        {
            if(inpModel.Text == String.Empty || inpRegistration.Text == String.Empty || inpDHP.Text == String.Empty ||
                inpYOM.Text == String.Empty || inpColor.Text == String.Empty || inpCapacity.Text == String.Empty || 
                cmbTransmission.Text == String.Empty || cmbFual.Text == String.Empty) 
            {
                string message = "All Data requied";
                string title = "";
                MessageBox.Show(message, title);
            }
            else
            {
                if (btnInsertCar.Text == "Add Car")
                {
                    CarModel Car = new CarModel(inpModel.Text, inpRegistration.Text, Convert.ToInt32(inpDHP.Text), Convert.ToInt32(inpYOM.Text), 
                                    inpColor.Text, Convert.ToInt32(inpCapacity.Text), cmbFual.Text, cmbTransmission.Text, "Avaliable");

                    carController.Add(Car);

                    emptyFields();

                    tbcCar.TabPages.Add(Preview);
                    tbcCar.SelectedTab = Preview;
                    tbcCar.TabPages.Remove(Insert);

                    getData();
                }
                else if (btnInsertCar.Text == "Update Car")
                {
                    CarModel Car = new CarModel(inpModel.Text, inpRegistration.Text, Convert.ToInt32(inpDHP.Text), Convert.ToInt32(inpYOM.Text),
                                    inpColor.Text, Convert.ToInt32(inpCapacity.Text), cmbFual.Text, cmbTransmission.Text, "Avaliable");

                    carController.Update(Car, ID);

                    emptyFields();

                    tbcCar.TabPages.Add(Preview);
                    tbcCar.SelectedTab = Preview;
                    tbcCar.TabPages.Remove(Insert);

                    getData();
                }
            }
        }

        private void btnInsertCancel_Click(object sender, EventArgs e)
        {
            tbcCar.TabPages.Add(Preview);
            tbcCar.SelectedTab = Preview;
            tbcCar.TabPages.Remove(Insert);
            emptyFields();
        }

        public void emptyFields()
        {
            inpModel.Text = String.Empty;
            inpRegistration.Text = String.Empty;
            inpDHP.Text = String.Empty;
            inpYOM.Text = String.Empty;
            inpColor.Text = String.Empty;
            inpCapacity.Text = String.Empty;
            cmbTransmission.Text = String.Empty;
            cmbFual.Text = String.Empty;
        }

        private void txtSearchCar_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCar.Text == String.Empty)
            {
                getData();
            }
            else
            {
                var Cars = carController.Search(txtSearchCar.Text);
                dgvCars.DataSource = Cars;
            }
        }

        private void inpDHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inpYOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inpCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
