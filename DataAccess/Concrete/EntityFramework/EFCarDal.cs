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
                                                 join co in context.Colors on ca.ColorId equals co.ColorId
                                                 join b in context.Brands on ca.BrandId equals b.BrandId
                    select new CarDetailDto { Description = ca.Description, 
                                                ColorId = co.ColorId, 
                                                ColorName = co.ColorName, 
                                                Id = ca.Id, 
                                                BrandId = ca.BrandId, 
                                                BrandName = b.BrandName, 
                                                DailyPrice = ca.DailyPrice, 
                                                ModelYear = ca.ModelYear};
                return result.ToList();
            }
        }
    }
}
