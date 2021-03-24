using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConserns.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [SecuredOperation("admin")]
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<OperationClaim>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user), Messages.UserOperationClaimsListed);
        }

        [CacheAspect]
        [SecuredOperation("admin")]
        public IDataResult<User> GetByMail(string email)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<User>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<User>(_userDal.Get(p => p.Email == email), Messages.UserListedByEmail);
        }

        [CacheAspect]
        //[SecuredOperation("admin")]
        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }

        [CacheAspect]
        [SecuredOperation("admin")]
        public IDataResult<User> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<User>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == id), Messages.UserDetailListed);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IUserService.Get")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {

            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IUserService.Get")]
        [TransactionScopeAspect]
        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {

            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IUserService.Get")]
        [TransactionScopeAspect]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }
    }
}
