using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice > 2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Günlük fiyat 2'den küçük olamaz!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetCarsByBrandId(int id)
        {
            return _carDal.Get(c => c.BrandId == id);
        }

        public Car GetCarsByColorId(int id)
        {
            return _carDal.Get(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
