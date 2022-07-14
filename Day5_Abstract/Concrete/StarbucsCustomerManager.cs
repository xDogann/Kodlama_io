using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5_Abstract.Abstract;
using Day5_Abstract.Entities;

namespace Day5_Abstract.Concrete
{
    public class StarbucsCustomerManager : CustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucsCustomerManager(ICustomerCheckService customerCheckPerson)
        {
            _customerCheckService = customerCheckPerson;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
            
        }

       





    }
}
