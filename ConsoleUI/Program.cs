using System;
using System.Linq;
using Bogus.DataSets;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            // ColorTest();
            // BrandTest();
            // UserTest();
            RentalTest();
            // VeriEkleme();
        }

        private static void RentalTest()
        {
            //DateTime rentDate1 = new DateTime(2021, 01, 15);
            //DateTime rentDate2 = new DateTime(2021, 02, 02);
            //DateTime returnDate1 = new DateTime(2021, 01, 17);
            //DateTime returnDate2 = new DateTime(2021, 02, 06);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //rentalManager.Add(new Rental() { CarId = 1, CustomerId = 1, RentDate = rentDate2, ReturnDate = returnDate2 });
            //rentalManager.Add(new Rental() { CarId = 2, CustomerId = 1, RentDate = rentDate1, ReturnDate = returnDate1 });
            //rentalManager.Add(new Rental() { CarId = 3, CustomerId = 2, RentDate = DateTime.Today });
            //// rentalManager.Add(new Rental() { CustomerId = 1, CarId = 5 });

            foreach (var variable in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(variable.CustomerId);
            }

        }

        //private static void VeriEkleme()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    Random rnd = new Random();

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Color color = new Color();
        //        color.ColorName = new Commerce("tr").Color();
        //        colorManager.Add(color);

        //        Brand brand = new Brand();
        //        brand.BrandName = new Commerce("tr").Categories(1)[0];
        //        brand.BrandModel = new Commerce("tr").ProductName();
        //        brandManager.Add(brand);

        //        for (int j = 0; j < 5; j++)
        //        {
        //            Car car = new Car();
        //            car.BrandId = brand.BrandId;
        //            car.ColorId = color.ColorId;

        //            car.DailyPrice = Convert.ToDecimal(new Commerce("tr").Price());
        //            car.Description = new Lorem("tr").Sentence(10);
        //            car.ModelYear = rnd.Next(1999, 2021);
        //            carManager.Add(car);
        //        }
        //    }
        //    Console.WriteLine("eklendi");
        //}

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            // userManager.Add(new User(){ UserName = "Emre", UserLastName = "Yuz", UserEmail = "emreyuz@xyzmail.com", UserPassword = "123"});
            userManager.Add(new User() { UserName = "Bora", UserLastName = "Yuz", UserEmail = "borayuz@xyzmail.com", UserPassword = "123" });

            foreach (var variable in userManager.GetAll().Data)
            {
                Console.WriteLine(variable.UserName + " " + variable.UserLastName + " " + variable.UserEmail);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Add(new Brand() { BrandName = "Mercedes", BrandModel = "GLA" });
            //brandManager.Add(new Brand() { BrandName = "BMW", BrandModel = "X3" });
            //brandManager.Add(new Brand() { BrandName = "Audi", BrandModel = "A4" });
            //brandManager.Add(new Brand() { BrandName = "Volkswagen", BrandModel = "Passat" });
            //brandManager.Add(new Brand() { BrandName = "Ford", BrandModel = "Focus" });

            foreach (var variable in brandManager.GetAll().Data)
            {
                Console.WriteLine(variable.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color() { ColorName = "Beyaz" });
            //colorManager.Add(new Color() { ColorName = "Siyah" });
            //colorManager.Add(new Color() { ColorName = "Kırmızı" });
            //colorManager.Add(new Color() { ColorName = "Lacivert" });

            foreach (var variable in colorManager.GetAll().Data)
            {
                Console.WriteLine(variable.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));

            //carManager.Add(new Car() { BrandId = 1, ColorId = 3, ModelYear = 2020, DailyPrice = 450, Description = "Az kilometreli" });
            //carManager.Add(new Car() { BrandId = 2, ColorId = 1, ModelYear = 2021, DailyPrice = 550, Description = "Sıfır" });
            //carManager.Add(new Car() { BrandId = 3, ColorId = 2, ModelYear = 2021, DailyPrice = 500, Description = "Az kilometreli" });
            //carManager.Add(new Car() { BrandId = 5, ColorId = 1, ModelYear = 2020, DailyPrice = 350, Description = "Az kilometreli" });
            //carManager.Add(new Car() { BrandId = 4, ColorId = 4, ModelYear = 2019, DailyPrice = 450, Description = "İyi durumda" });

            foreach (var variable in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(variable.BrandName + "/" + variable.BrandModel);
            }
        }
    }
}
