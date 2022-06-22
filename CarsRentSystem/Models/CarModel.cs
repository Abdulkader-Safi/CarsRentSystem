using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRentSystem.Models
{
    internal class CarModel
    {
        public int ID { get; set; }
        public string model { get; set; }
        public string registration { get; set; }
        public int dailyHirePrice { get; set; }
        public int YOM { get; set; }
        public string color { get; set; }
        public int capacity { get; set; }
        public string fual { get; set; }
        public string transmission { get; set; }
        public string status { get; set; }


        public CarModel()
        {

        }

        public CarModel(string model, string registration, int dailyHirePrice, int yOM, string color, int capacity, string fual, string transmission, string status)
        {
            this.model = model;
            this.registration = registration;
            this.dailyHirePrice = dailyHirePrice;
            this.YOM = yOM;
            this.color = color;
            this.capacity = capacity;
            this.fual = fual;
            this.transmission = transmission;
            this.status = status;
        }
    }
}
