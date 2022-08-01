using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager()
        {
        }

        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }
        public List<Car> GetAll()
        {
           return _CarDal.GetAll();
        }
    }
}
