using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5_Abstract.Abstract;
using Day5_Abstract.Entities;

namespace Day5_Abstract.Concrete
{
    public  class NeroCustomerManager : CustomerManager
    {
        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
