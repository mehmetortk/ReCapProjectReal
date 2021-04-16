using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult(Messages.MessageAdded);
        }

        public IResult Delete(int entity)
        {
            _colorDal.Delete(new Color{ColorId =entity});
            return new SuccessResult(Messages.MessageDeleted);

        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetAllByColorId(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorId == id));
        }
        
        public IResult Update(Color entity)
        {
               _colorDal.Update(entity);
            return new SuccessResult(Messages.MessageUpdated);

        }
    }
}
