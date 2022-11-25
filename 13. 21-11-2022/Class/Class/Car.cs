using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel; // 100 -> 100 - 10*10 = 0
        private double _millage; // 1000 -> 1010
        private double _fuelFor1Km; // 10

        public double FuelFor1Km 
        {
            get
            {
                return _fuelFor1Km;
            }
            set
            {
                if(value > 0)
                {
                    _fuelFor1Km = value;
                }
            }
        }

        public double Millage 
        {
            get { return _millage; }
            set
            {
                if(value >=0)
                {
                    _millage = value;
                }
            }
        }


        //public void FuelFor1KmSetter(double fuel)
        //{
        //    if (fuel > 0)
        //    {
        //        this._fuelFor1Km = fuel;
        //    }
        //}

        //public double FuelFor1KmGetter()
        //{
        //    return this._fuelFor1Km;
        //}




















        //public void Drive(int km) // 10
        //{
        //    if(km >0 && CurrentFuel - FuelFor1Km * km >= 0)
        //    {
        //        CurrentFuel -= FuelFor1Km * km;
        //        Millage += km;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Not enough fuel for {km} km");
        //    }
        //}

        //public void ShowInfo()
        //{
        //    Console.WriteLine($"CurrentFuel: {CurrentFuel}\nFuelFor1Km: {FuelFor1Km}\nMillage: {Millage}");
        //}
    }
}
