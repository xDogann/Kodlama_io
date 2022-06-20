using System;
using System.Collections.Generic;

namespace Day4_Constructer 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Abdussamed",
                LastName = "Dogan",
                City = "İstanbul"
            };
            Customer customer2 = new Customer(2,"Engin","Demiroğ","Ankara");

            Console.WriteLine(customer1.FirstName);

        }
    }

    class Customer
    {
        // default Contructer
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}