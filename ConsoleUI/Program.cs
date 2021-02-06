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

            Console.WriteLine("BrandId'ye göre");
            foreach (var item in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("ColorId'ye göre");
            foreach (var item in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(item.Description);
            }

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Açıklama: " + car.Description + " " + car.ModelYear + " Model " + "- " + car.DailyPrice + "TL/Gün"); ;
            //}

            // carManager.Add(new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 200, ModelYear = "2017", Description = "Ford Courier 2017 Model" });
            carManager.Add(new Car { CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = -3, ModelYear = "2017", Description = "Fiat Linea" });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 2, BrandName = "a"});
        }
    }
}
