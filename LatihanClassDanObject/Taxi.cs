using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    internal class Taxi
    {
        // Properties
        public string DriverName { get; set; }
       public string OnDuty { get; set; }
        public float NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Nama : {0} ", DriverName);

            Console.WriteLine("On Duty : {0} ", OnDuty);

            Console.WriteLine("Number of Passenger : {0} ", NumPassenger);
        }

       public void PickUpPassenger()
        {

            Console.WriteLine("{0} sedang menjemput penumpang ", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n ", DriverName);
        }
    }
}
