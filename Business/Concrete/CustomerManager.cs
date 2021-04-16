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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity); return new SuccessResult(Messages.MessageAdded);

        }

        public IResult Delete(int entity)
        {
            _customerDal.Delete(new Customer{CustomerId = entity}); return new SuccessResult(Messages.MessageDeleted);

        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetAllCustomerById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerId == id));

        }

        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity); return new SuccessResult(Messages.MessageUpdated);

        }
    }
}
