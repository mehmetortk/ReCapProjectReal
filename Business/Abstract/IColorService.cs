using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IColorService:IGeneralService<Color>
    {

        IDataResult<Color> GetAllByColorId(int id);
    }
}
