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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 CustomerId = c.CustomerId,
                                 UserId = u.Id,
                                 CompanyName = c.CompanyName,
                                 UserName = u.FirstName,
                                 UserLastName = u.LastName,
                                 UserEmail = u.Email
                             };
                return result.ToList();
            }
        }
    }
}
