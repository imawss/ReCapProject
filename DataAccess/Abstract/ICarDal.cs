using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<Car> GetCarsByBrandId(int id);

        List<CarDetailDto> GetCarsDetails();

        List<Car> GetCarsByColorId(int id);
    }
}
