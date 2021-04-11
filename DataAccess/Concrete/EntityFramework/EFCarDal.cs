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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors on ca.ColorId equals co.ColorId
                             join b in context.Brands on ca.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = ca.CarId,
                                 BrandId = ca.BrandId,
                                 ColorId = ca.ColorId,
                                 ModelYear = ca.ModelYear,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 BrandModel = b.BrandModel
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
