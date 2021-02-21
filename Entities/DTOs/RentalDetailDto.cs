using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalID { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
