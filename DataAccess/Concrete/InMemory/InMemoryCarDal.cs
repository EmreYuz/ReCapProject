using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car() {BrandId = 1, ColorId = 1, Description = "Corolla", DailyPrice = 200, CarId = 1, ModelYear = 2020},
                new Car() {BrandId = 2, ColorId = 1, Description = "Civic", DailyPrice = 250, CarId = 2, ModelYear = 2020},
                new Car() {BrandId = 3, ColorId = 2, Description = "Accent", DailyPrice = 200, CarId = 3, ModelYear = 2020},
                new Car() {BrandId = 4, ColorId = 3, Description = "Q5", DailyPrice = 600, CarId = 4, ModelYear = 2020},
                new Car() {BrandId = 5, ColorId = 3, Description = "X3", DailyPrice = 700, CarId = 5, ModelYear = 2020}
            };
        }
      

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public bool Any(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
