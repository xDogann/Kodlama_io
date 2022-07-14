using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5_Abstract.Abstract;
using Day5_Abstract.Entities;
using Day5_Abstract.Concrete;
using Day5_Abstract.ServiceReference1;

namespace Day5_Abstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            ServiceReference1.KPSPublicSoapClient client = new ServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NatoinalityId,customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
