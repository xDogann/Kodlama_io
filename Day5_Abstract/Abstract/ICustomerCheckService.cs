using Day5_Abstract.Entities;
using Day5_Abstract.Concrete;
using Day5_Abstract.Adapters;

namespace Day5_Abstract.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
