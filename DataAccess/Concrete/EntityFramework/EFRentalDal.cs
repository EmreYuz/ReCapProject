using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from r in context.Rentals
                             join ca in context.Cars on r.CarId equals ca.CarId
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId


                             select new RentalDetailDto()
                             {
                                 RentalId = r.RentalId,
                                 CarId = r.CarId,
                                 CustomerId = r.CustomerId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 BrandId = ca.BrandId,
                                 ColorId = ca.ColorId,
                                 ModelYear = ca.ModelYear,
                                 CompanyName = cu.CompanyName,
                                 DailyPrice = ca.DailyPrice,
                                 UserId = cu.UserId,
                             };

                return result.ToList();
            }
        }
    }
}
