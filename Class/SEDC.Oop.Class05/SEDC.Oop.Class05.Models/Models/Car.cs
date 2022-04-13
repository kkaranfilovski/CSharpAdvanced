using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Models.Models
{
    public class Car
    {
        public static int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime LicensePlateExpieryDate { get; set; }
        public List<Driver> AssignedDrivers { get; set; }

        public Car(string model, string licensePlate, DateTime expireyDate)
        {
            Id = IdCounter++;
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpieryDate = expireyDate;
        }
    }
}
