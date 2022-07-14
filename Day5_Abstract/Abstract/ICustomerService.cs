using Day5_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5_Abstract.Concrete;
using Day5_Abstract.Entities;
namespace Day5_Abstract.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
