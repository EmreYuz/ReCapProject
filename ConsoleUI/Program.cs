using System;
using System.Linq;
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
        }

        private static void RentalTest()
        {
            //DateTime rentDate1 = new DateTime(2021, 01, 15);
            //DateTime rentDate2 = new DateTime(2021, 02, 02);
            //DateTime returnDate1 = new DateTime(2021, 01, 17);
            //DateTime returnDate2 = new DateTime(2021, 02, 06);

            RentalManager rentalManager = new RentalManager(new EFRentalDal());

            //rentalManager.Add(new Rental() {CarID = 1, CustomerID = 1, RentDate = rentDate2, ReturnDate = returnDate2});
            //rentalManager.Add(new Rental() {CarID = 2, CustomerID = 1, RentDate = rentDate1, ReturnDate = returnDate1});
            //rentalManager.Add(new Rental() {CarID = 3, CustomerID = 1, RentDate = DateTime.Today});
            //rentalManager.Add(new Rental(){ CustomerID = 1, CarID = 5});

            foreach (var VARIABLE in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(VARIABLE.RentDate);
            }

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EFUserDal());
            // userManager.Add(new User(){ UserName = "Emre", UserLastName = "Yuz", UserEmail = "emreyuz@xyzmail.com", UserPassword = "123"});

            foreach (var VARIABLE in userManager.GetAll().Data)
            {
                Console.WriteLine(VARIABLE.UserName + " " + VARIABLE.UserLastName + " " + VARIABLE.UserEmail);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());

            //brandManager.Add(new Brand() { BrandName = "Mercedes", BrandModel = "GLA"});
            //brandManager.Add(new Brand() { BrandName = "BMW", BrandModel = "X3" });
            //brandManager.Add(new Brand() { BrandName = "Audi", BrandModel = "A4" });
            //brandManager.Add(new Brand() { BrandName = "Volkswagen", BrandModel = "Passat" });
            //brandManager.Add(new Brand() { BrandName = "Ford", BrandModel = "Focus" });

            foreach (var VARIABLE in brandManager.GetAll().Data)
            {
                Console.WriteLine(VARIABLE.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());

            //colorManager.Add(new Color() { ColorName = "Beyaz"});
            //colorManager.Add(new Color() { ColorName = "Siyah" });
            //colorManager.Add(new Color() { ColorName = "Kırmızı" });
            //colorManager.Add(new Color() { ColorName = "Lacivert" });

            foreach (var VARIABLE in colorManager.GetAll().Data)
            {
                Console.WriteLine(VARIABLE.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal(), new BrandManager(new EFBrandDal()));

            //carManager.Add(new Car(){ BrandID = 1, ColorID = 3, ModelYear = 2020, DailyPrice = 450, Description = "Az kilometreli"});
            //carManager.Add(new Car() { BrandID = 2, ColorID = 1, ModelYear = 2021, DailyPrice = 550, Description = "Sıfır" });
            //carManager.Add(new Car() { BrandID = 3, ColorID = 2, ModelYear = 2021, DailyPrice = 500, Description = "Az kilometreli" });
            //carManager.Add(new Car() { BrandID = 5, ColorID = 1, ModelYear = 2020, DailyPrice = 350, Description = "Az kilometreli" });
            //carManager.Add(new Car() { BrandID = 4, ColorID = 4, ModelYear = 2019, DailyPrice = 450, Description = "İyi durumda" });

            foreach (var VARIABLE in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(VARIABLE.BrandName + "/" + VARIABLE.BrandModel);
            }
        }
    }
}
