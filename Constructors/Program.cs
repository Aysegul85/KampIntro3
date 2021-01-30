using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

                
            Customer customer3 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Customer customer4 = new Customer();
            customer4.Id = 3;
            customer4.FirstName = "Ayşe";
            customer4.LastName = "Girgin";
            customer4.City = "Kocaeli";

            Console.WriteLine(customer3.FirstName);




        }


        static void Method(int Id, string firstName, string lastName, string city)
        {

        }



    }


    class Customer
    {
        public Customer()    //ctor
        {

        }


        public Customer(int Id, string firstName, string lastName, string city)      //ctor tab tab    //default constructor
        {
            Id = Id;
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
