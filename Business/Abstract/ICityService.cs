﻿
using Core6.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();

        IDataResult<City> GetByCityId(int cityId);


        IResult Add(City city);
        IResult Update(City city);
       
        IResult DeleteUser(City city);
    }
}
