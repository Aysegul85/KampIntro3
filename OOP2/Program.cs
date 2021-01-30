using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12546";
            customer1.CustomerName = "Engin";
            customer1.CustomerSurname = "Demiroğ";
            customer1.TcNo = "1234576980";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "53421";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "172637465";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);






        }
    }
}
