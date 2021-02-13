using System;
using System.Collections.Generic;
using System.Text;
using Core;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal:EfEntityRepositoryBase<Color,CarRentContext>,IColorDal
    {
    }
}
