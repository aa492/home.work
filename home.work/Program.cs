using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home.work
{
    class vehicle
    {
        public string Brand;

    }
    class MotorVehicle:vehicle
    {
        public string modelname;


    }
    class car:MotorVehicle
    {

    }
    class Truck:MotorVehicle
    {


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car();
            mycar.Brand = " kia ";
            mycar.modelname = "azera";
            Truck mytruck = new Truck();
            mytruck.Brand = "mercedes";
            mytruck.modelname = "v12";
            Console.WriteLine(mycar.Brand);
            Console.WriteLine(mycar.modelname);
            Console.WriteLine(mytruck.Brand);
            Console.WriteLine( mytruck.modelname );
            Console.ReadLine();

        }
    }
}
