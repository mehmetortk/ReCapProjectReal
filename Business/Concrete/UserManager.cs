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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User entity)
        { 
            _userDal.Add(entity); return new SuccessResult(Messages.MessageAdded);

        }

        public IResult Delete(int entity)
        {
            _userDal.Delete(new User{UserId = entity});
            return new SuccessResult(Messages.MessageDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetAllByUserId(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserId == id));
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(Messages.MessageUpdated);

        }
    }
}
