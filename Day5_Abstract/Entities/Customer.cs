using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5_Abstract.Abstract;
using Day5_Abstract.Entities;

namespace Day5_Abstract.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NatoinalityId { get; set; }

    }
}
