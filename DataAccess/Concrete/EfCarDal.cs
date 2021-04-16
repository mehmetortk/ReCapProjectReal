using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalContext>, ICarDal
    {
        public List<CarDetailsDto> GetByCarDetails()
        {
            using (RentalContext context = new RentalContext())
            {
                var result1 = from c in context.Cars
                              join o in context.Colors on c.ColorId equals o.ColorId
                              join a in context.Brands on c.BrandId equals a.BrandId
                              join d in context.Rentals
                                  on c.CarId equals d.CarId
                              select new CarDetailsDto
                              {
                                  BrandName = a.BrandName,
                                  ColorName = o.ColorName,
                                  CarDailyPrice = c.CarDailyPrice,
                                  CarModelYear = c.CarModelYear,
                                  CarDescription = c.CarDescription,
                                  CarRentDate = d.CarRentDate,
                              };
                return result1.ToList();
            }

        }

        public List<UserDetailsDto> GetByUserDetails()
        {
            using (RentalContext context = new RentalContext())
            {
                var result2 = from c in context.Customers
                              join p in context.Users on
                                  c.UserId equals p.UserId
                              select new UserDetailsDto
                              {
                                  CompanyName = c.CompanyName,
                                  UserName = p.UserName,
                                  UserLastName = p.UserLastName,

                              };
                return result2.ToList();
            }
        }
    }
}
