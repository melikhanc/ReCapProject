using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        ICarDal _brandsDal;
        ICarDal _colorsDal;

        public CarManager(ICarDal carDal)
        {

            _carDal = carDal;
            _brandsDal = carDal;
            _colorsDal = carDal; 


        }

        public List<Car> GetAll()
        {

            return _carDal.GetAll();

        }
        public List<Brand> GetBrands()
        {

            return _brandsDal.GetBrands();

        }
        public List<Color> GetColors()
        {

            return _colorsDal.GetColors();

        }
        

       
    }
}
