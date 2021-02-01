using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           // Customer customer = new Customer();
           // customer.FirstName = "Ali";

            Person[] persons = new Person[3]
            {
                new Customer {FirstName="Engin"}, new Student{FirstName= "Derin" }, new Person{FirstName="Salih" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }




        }


    }
}
