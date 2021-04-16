using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;

namespace Business.Abstract
{
   public interface ICarService:IGeneralService<Car>
   {
       IDataResult<Car> GetAllByCarId(int id);
       IDataResult<List<CarDetailsDto>> GetByCarDetails();
       IDataResult<List<UserDetailsDto>> GetByUserDetails();

    }
}
