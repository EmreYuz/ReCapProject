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
    public class EFCustomerDal : EfEntityRepositoryBase<Customer, CarDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Customers
                                                     join u in context.Users on c.UserID equals u.UserID

                    select new CustomerDetailDto 
                    {  
                        CustomerID = c.CustomerID,
                        UserID = u.UserID,
                        CompanyName = c.CompanyName,
                        UserName = u.UserName,
                        UserLastName = u.UserLastName,
                        UserEmail = u.UserEmail
                    };
                return result.ToList();
            }
        }
    }
}
