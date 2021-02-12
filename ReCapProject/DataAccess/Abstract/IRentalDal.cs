using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        List<RentDetailDto> GetDetailRental();
    }
}
