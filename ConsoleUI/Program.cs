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
            //BrandIdColorIdTest();
            //BrandTest();
            //ColorTest();
            //CarTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { RentalId = 5, CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 02, 12) });
            Console.WriteLine(result.Message);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.ColorName + " / " + car.Description + " / " + car.DailyPrice);
                }
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

        private void BrandIdColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("BrandId'ye göre");
            var brandResult = carManager.GetCarsByBrandId(3);
            foreach (var item in brandResult.Data)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("ColorId'ye göre");
            var colorResult = carManager.GetCarsByColorId(2);
            foreach (var item in colorResult.Data)
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
