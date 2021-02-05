using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 3, ColorId = 2, ModelYear = "2011", 
                        DailyPrice = 80, Description = "Hyundai Accent Era"},

                new Car{CarId = 2, BrandId = 5, ColorId = 1, ModelYear = "2011", 
                        DailyPrice = 110, Description = "Fiat Fiorino 2011 Model"},

                new Car{CarId = 3, BrandId = 2, ColorId = 2, ModelYear = "2017", 
                        DailyPrice = 130, Description = "Ford Courier 2017 Model"},

                new Car{CarId = 4, BrandId = 3, ColorId = 1, ModelYear = "2011", 
                        DailyPrice = 120, Description = "Fiat Linea 2017 Model"},

                new Car{CarId = 5, BrandId = 1, ColorId = 4, ModelYear = "2020", 
                        DailyPrice = 100, Description = "Fiat Linea 2017 Model"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
