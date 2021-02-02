using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

           
            

            foreach (var car in carManager.GetAll()) { 
                Console.WriteLine(car.ModelYear + " Model Aracımızın adı " + car.Description + "\n" 
                    +"Renk Kodu : " +car.ColorId + "\n" 
                    +"Marka Kodu :"+car.BrandId );
            }
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Marka Bilgilerimiz, Bilgi Amaçlı Aşağıda Listelenmiştir.");

            foreach (var brand in carManager.GetBrands())
            {

                Console.WriteLine(brand.BrandId +" : "+ brand.BrandName );

            }
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Renk Bilgilerimiz, Bilgi Amaçlı Aşağıda Listelenmiştir.");
            foreach (var color in carManager.GetColors())
            {
                Console.WriteLine(color.ColorId +" : " +color.ColorName);

            }

           
            
        }
    }
}
