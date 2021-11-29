using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carService = new CarManager(new EfCarDal());

            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
