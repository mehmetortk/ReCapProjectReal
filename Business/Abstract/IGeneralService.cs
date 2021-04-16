using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Abstract
{
   public interface IGeneralService<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IResult Delete(int entity);
        IResult Update(T entity);
    }
}
