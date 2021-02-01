using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }



    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine();
        }

        public void GetSalary()
        {
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine();
        }
    }
    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine();
        }

        public void GetSalary()
        {
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine();
        }
    }


    class Robots : IWorker
    {
        public void Work()
        {
            Console.WriteLine();
        }
    }
}


