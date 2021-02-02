using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _car;
        List<Brand> _brand;
        List<Color> _color;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=1, DailyPrice=7500, Description="CLA 200" , ModelYear=2015},
                new Car{ Id=2, BrandId=2, ColorId=1, DailyPrice=7000, Description="5.20 i" , ModelYear=2014},
                new Car{ Id=3, BrandId=2, ColorId=2, DailyPrice=7500, Description="5.20 xDrive " , ModelYear=2012},
                new Car{ Id=4, BrandId=1, ColorId=3, DailyPrice=8500, Description="GLA 200" , ModelYear=2013},
                new Car{ Id=5, BrandId=3, ColorId=2, DailyPrice=12500, Description="Reventon Roadster" , ModelYear=2006},
                new Car{ Id=6, BrandId=3, ColorId=3, DailyPrice=14000, Description="Diablo GT 1" , ModelYear=2005},
                new Car{ Id=7, BrandId=4, ColorId=4, DailyPrice=25, Description="Şahin" , ModelYear=1990},




            };

            _brand = new List<Brand>
            {
                new Brand{ BrandId=1, BrandName="Mercedes"},
                new Brand{ BrandId=2, BrandName="BMW"},
                new Brand{ BrandId=3, BrandName="Lamborghini"},
                new Brand{ BrandId=4, BrandName="Tofaş"}


            };

            _color = new List<Color>
            {
                new Color{ ColorId=1, ColorName="Mavi"},
                new Color{ ColorId=2, ColorName="Kırmızı"},
                new Color{ ColorId=3, ColorName="Beyaz"},
                new Color{ ColorId=4, ColorName="Siyah"}


            };


        }
        public void Add(Car car)
        {

            _car.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault( c=> c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Brand> GetBrands()
        {
            return _brand;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public List<Color> GetColors()
        {
            return _color;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }

}
