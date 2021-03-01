﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IResult Add(CarImage carImage,IFormFile file);
        IResult Update(CarImage carImage,IFormFile file);
        IResult Delete(CarImage carImage);
    }
}
