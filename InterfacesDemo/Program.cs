﻿internal class Program
{
    private static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            IWorker[] workers =
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            foreach (Worker worker in workers)
            {
                worker.Work();
            }
            IEat[] eats =
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {

        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {

        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
        }
    }
}
