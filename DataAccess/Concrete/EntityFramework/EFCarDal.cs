using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from ca in context.Cars 
                                                 join co in context.Colors on ca.ColorID equals co.ColorID
                                                 join b in context.Brands on ca.BrandID equals b.BrandID
                    select new CarDetailDto 
                    {   
                        CarId = ca.CarID,
                        BrandId = ca.BrandID,
                        ColorId = ca.ColorID,
                        ModelYear = ca.ModelYear,
                        DailyPrice = ca.DailyPrice,
                        Description = ca.Description,
                        ColorName = co.ColorName,
                        BrandName = b.BrandName,
                        BrandModel = b.BrandModel
                    };

                 return result.ToList();
            }
        }
    }
}
