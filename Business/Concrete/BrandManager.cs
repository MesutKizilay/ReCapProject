﻿using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        public IResult AddBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult UpdateBrand(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
