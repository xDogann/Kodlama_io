using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5_Abstract.Concrete;
using Day5_Abstract.Entities;
using Day5_Abstract.Abstract;
using Day5_Abstract.Adapters;

namespace Day5_Abstract.Abstract
{
    public abstract class CustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
