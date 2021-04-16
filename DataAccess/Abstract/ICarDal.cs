using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailsDto> GetByCarDetails();
        List<UserDetailsDto> GetByUserDetails();


    }
}
