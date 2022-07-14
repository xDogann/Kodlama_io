using Day5_Abstract.Abstract;
using Day5_Abstract.Adapters;
using Day5_Abstract.Concrete;
using Day5_Abstract.Entities;

namespace Day5_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new StarbucsCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2008, 5, 10),
                FirstName = "Abdussamed",
                LastName = "Doğan",
                NatoinalityId = "4641512"
            });
        }
    }
}
