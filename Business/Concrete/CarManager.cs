using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if (car.DailyPrice >= 0 && car.CarName.Length >= 2)
            {
                _carDal.Add(car);
            }
            else
            {
                throw new NotImplementedException("Kiralama fiyatı sıfırdan büyük olmalıdır veya araç adı 2 karakterden uzun olmalıdır");
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

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarsDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
