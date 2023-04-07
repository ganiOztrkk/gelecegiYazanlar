using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public interface ICustomerValidation
    {
        bool Validate(ICustomer customer);
    }
}
