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
                new Car() {BrandID = 1, ColorID = 1, Description = "Corolla", DailyPrice = 200, CarID = 1, ModelYear = 2020},
                new Car() {BrandID = 2, ColorID = 1, Description = "Civic", DailyPrice = 250, CarID = 2, ModelYear = 2020},
                new Car() {BrandID = 3, ColorID = 2, Description = "Accent", DailyPrice = 200, CarID = 3, ModelYear = 2020},
                new Car() {BrandID = 4, ColorID = 3, Description = "Q5", DailyPrice = 600, CarID = 4, ModelYear = 2020},
                new Car() {BrandID = 5, ColorID = 3, Description = "X3", DailyPrice = 700, CarID = 5, ModelYear = 2020}
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
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.BrandID = car.BrandID;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
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
