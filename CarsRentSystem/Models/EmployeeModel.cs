using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarsRentSystem.Models;
using CarsRentSystem.Controller;

namespace CarsRentSystem.Models
{
    internal class EmployeeModel
    {
		public int ID { get; set; }
		public string fullName { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public string role { get; set; }
		public int phoneNumber { get; set; }
		public int salary { get; set; }

		public EmployeeModel()
        {

        }

		public EmployeeModel(string fullName, string email, string password, string role, int phoneNumber, int salary)
        {
            this.fullName = fullName;
            this.email = email;
            this.password = password;
            this.role = role;
            this.phoneNumber = phoneNumber;
            this.salary = salary;
        }
    }
}
