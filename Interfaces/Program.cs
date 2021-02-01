using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robots()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }



            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }


            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }

        }
    }
}


        
    
    

