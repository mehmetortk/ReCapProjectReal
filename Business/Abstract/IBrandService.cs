using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    interface IBrandService:IGeneralService<Brand>
    {
       IDataResult<Brand> GetAllByBrandId(int id);
    }
}
