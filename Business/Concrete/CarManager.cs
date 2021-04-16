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
using Entity.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car entity)
        {
            _carDal.Add(entity); return new SuccessResult(Messages.MessageAdded);
        }

        public IResult Delete(int entity)
        {
            _carDal.Delete(new Car{CarId = entity});
            return new SuccessResult(Messages.MessageDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetAllByCarId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=> p.CarId==id));
        }

        public IDataResult<List<CarDetailsDto>> GetByCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetByCarDetails());
        }

        public IDataResult<List<UserDetailsDto>> GetByUserDetails()
        {
            return new SuccessDataResult<List<UserDetailsDto>>(_carDal.GetByUserDetails());
        }

        public IResult Update(Car entity)
        {
            _carDal.Update(entity); return new SuccessResult(Messages.MessageUpdated);
        }
    }
}
