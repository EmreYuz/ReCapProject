using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç eklendi.");
            }
            else
            {
                Console.WriteLine("Aracın günlük fiyatı 0 TL'den büyük olmadıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetByBrandId(int brandId)
        {
            return _carDal.Get(b => b.BrandId == brandId);
        }

        public Car GetByColorId(int colorId)
        {
            return _carDal.Get(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
