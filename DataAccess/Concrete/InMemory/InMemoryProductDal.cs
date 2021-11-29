using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class EfCarDal : ICarDal
    {

        List<Car> _cars;

        public EfCarDal()
        {
            _cars = new List<Car>
            {
            new Car{Id = 1,BrandId = 1,ColorId=2,ModelYear=2012,DailyPrice=8000,Description="Uzun yol için kiralık araba"},
            new Car{Id = 2,BrandId = 3,ColorId=1,ModelYear=2009,DailyPrice=4500,Description="Arazi için kiralık araba"},
            new Car{Id = 3,BrandId = 1,ColorId=5,ModelYear=2018,DailyPrice=5800,Description="Günlük kullanım için kiralık araba"}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carForDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carForDelete);
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

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carForUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carForUpdate.BrandId = car.BrandId;
            carForUpdate.ColorId = car.ColorId;
            carForUpdate.ModelYear = car.ModelYear;
            carForUpdate.DailyPrice = car.DailyPrice;
            carForUpdate.Description = car.Description;
        }
    }
}
