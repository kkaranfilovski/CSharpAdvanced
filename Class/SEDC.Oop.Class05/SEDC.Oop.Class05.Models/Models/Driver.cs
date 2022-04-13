using SEDC.Oop.Class05.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Models.Models
{
    public class Driver
    {
        public static int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shifts Shift { get; set; }
        public Car Car { get; set; }
        public string License { get; set; }
        public DateTime LicenseExpieryDate { get; set; }

        public Driver(string fName, string lName, Shifts shift, string license, DateTime expireyDate)
        {
            Id = IdCounter++;
            FirstName = fName;
            LastName = lName;
            Shift = shift;
            License = license;
            LicenseExpieryDate = expireyDate;
        }
    }
}
