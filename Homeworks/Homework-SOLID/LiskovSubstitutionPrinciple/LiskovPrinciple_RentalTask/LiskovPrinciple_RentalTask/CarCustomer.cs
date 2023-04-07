using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public class CarCustomer : Customer
    {
        public bool DrivingLicence { get; set; }

        public CarCustomer(int customerAge, bool drivingLicence, string customerName,string customerSurname, string customerPhone) : base(customerAge,customerName,customerSurname,customerPhone)
        {
            this.DrivingLicence = drivingLicence;
            if (!drivingLicence)
            {
                throw new ArgumentException("It's forbidden to rent a car without driving licence");
            }
        }
    }
}
