using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Araç kiralama sistemimize hoşgeldiniz \n");
            Console.WriteLine("<<<<<<<<<< Araçlarımız >>>>>>>>>> \n");
           
            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine("<<<"+car.Description + ">>>");
                Console.WriteLine();
            }
            //CarId=1-> binek, 2-> ticari, 3-> servis || BrandId=1-> Bmw, 2-> Mercedes, 3-> Volkswagen, 4-> Renault
            //ColorId=1-> kırmızı, 2-> siyah, 3-> mavi, 4-> beyaz renkleri temsil ediyor
            
        }
    }
}
