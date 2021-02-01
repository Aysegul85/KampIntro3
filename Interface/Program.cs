using System;

namespace Interface
{
    class Program
    {//interface new lenemez
        static void Main(string[] args)
        {
            //IPersonManager cusomerManager = new CustomerManager();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            //projectManager.AddCustomer(customerManager);
            //projectManager.AddEmployee(employeeManager);
            //bunun yerine
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);

            //CustomerManager customerManager = new CustomerManager(); olarak yazılmaması durumunda
            //ProjectManager.Add(new CustomerManager());
            

        }

        interface IPersonManager
        {
            //unimplamented operation
            void Add();
            void Uptade();
           
        }


        //inherist-class ......... implements-interface
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müşteri eklendi.");
            }

            public void Uptade()
            {
                Console.WriteLine("Müşteri güncellendi.");
            }
        }
        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Personel eklendi.");
            }

            public void Uptade()
            {
                Console.WriteLine("Personel güncellendi.");
            }
        }



        // class ProjectManager
        //{
        //    public void AddCustomer (CustomerManager customerManager)
        //    {
        //        customerManager.Add();
        //    }

        //    public void AddEmployee ( EmployeeManager employeeManager)
        //    {
        //        employeeManager.Add();
        //    }


        //}
        
        //bunun yerine


        class ProjectManager
        {
            public void Add (IPersonManager personManager)
            {
                personManager.Add();
            }
        }


    }
}
