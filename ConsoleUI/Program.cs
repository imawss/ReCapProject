using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarDal carDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(carDal);
        }
    }
}
