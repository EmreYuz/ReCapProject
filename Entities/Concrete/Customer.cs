using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }
    }
}
