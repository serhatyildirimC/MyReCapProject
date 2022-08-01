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
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, Description = "abc", ModelYear = 2000 },
                new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 150000, Description = "abc", ModelYear = 2005 },
                new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 170000, Description = "abc", ModelYear = 2007 },
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 300000, Description = "abc", ModelYear = 2010 },
                new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 500000, Description = "abc", ModelYear = 2017 },
                new Car { Id = 6, BrandId = 3, ColorId = 2, DailyPrice = 650000, Description = "abc", ModelYear = 2021 }
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

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
