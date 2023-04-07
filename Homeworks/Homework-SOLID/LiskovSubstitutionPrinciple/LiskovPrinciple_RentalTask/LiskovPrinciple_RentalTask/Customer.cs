using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public abstract class Customer : ICustomer, ICustomerValidation
    {
        protected Customer(int customerAge, string customerName, string customerSurname,string customerPhone)
        {
            CustomerAge = customerAge;
            CustomerName = customerName;
            CustomerSurname = customerSurname;
            CustomerPhone = customerPhone;
            if (!Validate(this))
            {
                throw new ArgumentException("Invalid customer age.");
            }
        }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerAge { get;}
        public string CustomerPhone { get; set; }

        public bool Validate(ICustomer customer)
        {   
            return CustomerAge >= 18 ? true : false;
        }
    }
}