using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarGalleryTask.Models
{
    internal class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Car[] Cars;

        public Gallery()
        {
            Cars = Array.Empty<Car>();
        }


        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[^1] = car;
        }

        public void AddCar(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                AddCar(cars[i]);
            }
        }

        public void AddCar(ref Car[] carArray,Car car)
        {
            Array.Resize(ref carArray, carArray.Length + 1);
            carArray[^1] = car;
        }

        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{car.Id} {car.Name} {car.CarCode} {car.Speed}");
            }
        }

        public Car[] GetAllCars()
        {
            return Cars;
        }

        public Car FindCarById(int id)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                    return Cars[i];
                }
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode.ToLower() == carCode.ToLower())
                {
                    return Cars[i];
                }
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(double minSpeed,double maxSpeed)
        {
            Car[] filteredCars = Array.Empty<Car>();

            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Speed >= minSpeed && Cars[i].Speed <= maxSpeed)
                {
                    AddCar(ref filteredCars, Cars[i]);
                }
            }
            return filteredCars;
        }
    }
}
