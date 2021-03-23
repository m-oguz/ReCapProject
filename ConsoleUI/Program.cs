using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());
            int i = 1;
            Console.WriteLine("-----------Rental Cars Available-----------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Option " + i +":  "+ car.Description + "\tPrice : " + car.DailyPrice +"Eur/day " );
                i++;
            }
            Console.WriteLine("--------------End of the list--------------");

        }
    }
}
