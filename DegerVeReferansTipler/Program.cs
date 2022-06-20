using System;

namespace Day3_DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "Doğan";

            person2 = person1;
            person1.Name = "Derin";

            Console.WriteLine(person2.Name);
            Console.WriteLine("\n---\n");


            Person person = new Person();
            Customer customer = new Customer();
            Employee employee = new Employee();
            employee.Name = "Veli";

            Person person3 = customer;
            customer.CreditCardNumber = "301515322";
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            Console.WriteLine("\n---\n");
            person1.Name = Console.ReadLine();
            PersonManager personManager= new PersonManager();
            Console.WriteLine("Girdiğiniz kişi veri tabanına ekleniyor..");
            personManager.Add(employee);
            Console.WriteLine("Eklendi..");


        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person// Personal numarası
        { 
            public int EmployeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine("\n- " + person.Name);
            }
        }
    }
}