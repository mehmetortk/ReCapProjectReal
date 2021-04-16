using System;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete;
using Entity.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result1 = carManager.GetByCarDetails();
            var result2 = carManager.GetByUserDetails();

            if (result1.Success == true)
            {
                var i = 1;
                foreach (var car in result1.Data)
                {
                    Console.WriteLine( i+ ".{0}|{1}|{2}|{3}|{4}|{5}", car.BrandName, car.CarDescription, car.ColorName
                    , car.CarModelYear, car.CarDailyPrice, car.CarRentDate);
                    i++;
                }

                foreach (var user in result2.Data)
                {
                    Console.WriteLine(i + ".{0}|{1}|{2}", user.CompanyName, user.UserName, user.UserLastName);
                    i++;
                }
            }
            else
            {
                Console.WriteLine(Messages.MessageError);
            }


        }
    }
}
