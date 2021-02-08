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
            // BrandIdColorIdTest();
            // CarTest();
            // BrandTest();
            //ColorTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
               Console.WriteLine(car.BrandName + " / " + car.ColorName + " / " + car.Description + " / " + car.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorId = 4, ColorName = "Mavi" });
            //colorManager.Update(new Color { ColorId = 1, ColorName = "Turuncu" });
            colorManager.Delete(new Color { ColorId = 4, ColorName = "Mavi" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandId = 1, BrandName = "Fiat Linea 2017 Model" });
            brandManager.Update(new Brand { BrandId = 2, BrandName = "güncellendi" });
            //brandManager.Delete(new Brand { BrandId = 5, BrandName = "Fiat Fiorino" });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            // carManager.Add(new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 200, ModelYear = "2017", Description = "Ford Courier 2017 Model" });
            // carManager.Add(new Car { CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = -3, ModelYear = "2017", Description = "Fiat Linea" });
            carManager.Update(new Car { CarId = 3, BrandId = 3, ColorId = 2, DailyPrice = 160, ModelYear = "2018", Description = "Fiat Linea 2020 Model" });
            carManager.Delete(new Car { CarId = 1, BrandId = 3, ColorId = 1, DailyPrice = 80, ModelYear = "2011", Description = "Hyundai Accent Era 2011 Model" });
        }

        private static CarManager BrandIdColorIdTest()
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

            return carManager;
        }
    }
}
