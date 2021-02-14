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
            CarTest();
            // ColorTest();
            // BrandTest();


        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());

            foreach (var VARIABLE in brandManager.GetAll())
            {
                Console.WriteLine(VARIABLE.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());

            foreach (var VARIABLE in colorManager.GetAll())
            {
                Console.WriteLine(VARIABLE.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            
            foreach (var VARIABLE in carManager.GetCarDetails())
            {
                Console.WriteLine(VARIABLE.BrandName + " / " + VARIABLE.ColorName + " / " + VARIABLE.ModelYear);
            }
        }
    }
}
