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
    public class EFRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from r in context.Rentals
                    join ca in context.Cars on r.CarID equals ca.CarID
                    join cu in context.Customers on r.CustomerID equals cu.CustomerID

                    select new RentalDetailDto()
                    {
                        RentalID = r.RentalID,
                        CarID = r.CarID,
                        CustomerID = r.CustomerID,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate,
                        BrandID = ca.BrandID,
                        ColorID = ca.ColorID,
                        ModelYear = ca.ModelYear,
                        CompanyName = cu.CompanyName,
                        DailyPrice = ca.DailyPrice,
                        UserID = cu.UserID
                    };

                return result.ToList();
            }
        }
    }
}
