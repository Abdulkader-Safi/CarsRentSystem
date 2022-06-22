using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRentSystem.Models
{
    internal class CustomerModel
    {
		public int ID { get; set; }
		public string fullName { get; set; }
		public string email { get; set; }
		public int phoneNumber { get; set; }
		public string gender { get; set; }

		public CustomerModel()
        {

        }

		public CustomerModel(string fullName, string email, int phoneNumber, string gender)
        {
            this.fullName = fullName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
        }
    }
}
