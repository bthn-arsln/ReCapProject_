using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Açıklama: " + car.Description + " " + car.ModelYear + " Model " + "- " + car.DailyPrice + "TL/Gün"); ;
            //}

            // carManager.Add(new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 200, ModelYear = "2017", Description = "Ford Courier 2017 Model" });
            carManager.Add(new Car { CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = -3, ModelYear = "2017", Description = "Fiat Linea" });

            //Console.WriteLine(carManager.GetCarsByBrandId(3).Description);
            //Console.WriteLine(carManager.GetCarsByColorId(2).Description);

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 2, BrandName = "a"});
        }
    }
}
