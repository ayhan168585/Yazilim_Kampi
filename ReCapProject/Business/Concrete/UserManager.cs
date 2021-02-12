using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.UserListed);
        }

        public IDataResult<User> GetById(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<User>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<User>(_userDal.Get(p=>p.Id==id),Messages.UserDetailListed);
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length<2)
            {
                return new ErrorResult(Messages.UserFirstNameInvalid);
            }
            else if (user.LastName.Length<2)
            {
                return new ErrorResult(Messages.UserLastNameInvalid);
            }
            else if (!user.Email.Contains("@"))
            {
                return new ErrorResult(Messages.UserEmailInvalid);
            }
            else if (user.Password.Length<4)
            {
                return new ErrorResult(Messages.UserPasswordInvalid);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Update(User user)
        {
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UserFirstNameInvalid);
            }
            else if (user.LastName.Length < 2)
            {
                return new ErrorResult(Messages.UserLastNameInvalid);
            }
            else if (!user.Email.Contains("@"))
            {
                return new ErrorResult(Messages.UserEmailInvalid);
            }
            else if (user.Password.Length < 4)
            {
                return new ErrorResult(Messages.UserPasswordInvalid);
            }
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }
    }
}
