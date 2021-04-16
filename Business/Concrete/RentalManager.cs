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
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental entity)
        {
            _rentalDal.Add(entity); return new SuccessResult(Messages.MessageAdded);

        }

        public IResult Delete(int entity)
        {
            _rentalDal.Delete(new Rental{RentalId = entity}); return new SuccessResult(Messages.MessageDeleted);

        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetAllByRentalId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p=> p.RentalId==id));
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity); return new SuccessResult(Messages.MessageUpdated);
                
        }
    }
}
