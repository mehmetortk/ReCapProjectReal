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
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand entity)
        {
            _brandDal.Add(entity);
            return new SuccessResult(Messages.MessageAdded);
        }

        public IResult Delete(int entity)
        {
            _brandDal.Delete(new Brand {BrandId = entity});
            return new SuccessResult(Messages.MessageDeleted);
        }


        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.MessageListed);
        }

        public IDataResult<Brand> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == id));
        }

        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.MessageUpdated);
        }
    }
}
