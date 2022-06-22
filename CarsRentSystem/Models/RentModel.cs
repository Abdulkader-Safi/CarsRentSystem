using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRentSystem.Models
{
    internal class RentModel
    {
        public int ID { get; set; }
        public int customerID { get; set; }
        public int carID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int rentCost { get; set; }
        public string status { get; set; }

        public RentModel()
        {

        }

        public RentModel(int customerID, int carID, int employeeID, DateTime startDate, DateTime endDate, int rentCost, string status)
        {
            this.customerID = customerID;
            this.carID = carID;
            this.EmployeeID = employeeID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.rentCost = rentCost;
            this.status = status;
        }
    }
}
