using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage,ReCapProjectContext>,ICarImageDal
    {
        public void AddImage(CarImage carImage)
        {
           
        }
    }
}
