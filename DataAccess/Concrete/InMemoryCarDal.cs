using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { Id = 1, BrandId = 1, ColorId = "Gray", DailyPrice = 100000, Description = "Sedan", ModelYear = 2009 },
            new Car { Id = 2, BrandId = 2, ColorId = "White", DailyPrice = 235000, Description = "Coupe", ModelYear = 2016 },
            new Car { Id = 3, BrandId = 1, ColorId = "Black", DailyPrice = 110000, Description = "Hatchback", ModelYear = 2018 },
            new Car { Id = 4, BrandId = 3, ColorId = "Green", DailyPrice = 500000, Description = "Truck", ModelYear = 2021 },
            new Car { Id = 5, BrandId = 4, ColorId = "Blue", DailyPrice = 120000, Description = "Sedan", ModelYear = 2012 },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
