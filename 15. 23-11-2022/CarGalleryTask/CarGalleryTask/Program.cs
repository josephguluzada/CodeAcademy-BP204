using CarGalleryTask.Models;
namespace CarGalleryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes");
            car1.Speed = 100;
            Car car2 = new Car("Lamborgini");
            car2.Speed = 150;
            Car car3 = new Car("Prius");
            car3.Speed = 480;


            Gallery gallery = new();

            //gallery.AddCar(car1);
            //gallery.AddCar(car2);
            //gallery.AddCar(car3);

            Car[] cars = { car1, car2, car3 };

            gallery.AddCar(cars);

            gallery.ShowAllCars();
            Console.WriteLine("============================");
            Car wantedCar =  gallery.FindCarById(3);

            if(wantedCar != null)
            {
                Console.WriteLine(wantedCar.Id + " " + wantedCar.Name);
            }
            else
            {
                Console.WriteLine("Bele id'li masin yoxdur");
            }

            Console.WriteLine("=============================");

            Car wantedCar2 = gallery.FindCarByCarCode("Pr1003");
            if (wantedCar2 != null)
            {
                Console.WriteLine(wantedCar2.Id + " " + wantedCar2.Name);
            }
            else
            {
                Console.WriteLine("Bele code'lu masin yoxdur");
            }

            Console.WriteLine("=============================");

            Car[] wantedCars = gallery.FindCarsBySpeedInterval(90,500);

            if(wantedCars.Length > 0)
            {
                foreach (Car car in wantedCars)
                {
                    Console.WriteLine($"{car.Id} {car.Name} {car.CarCode} {car.Speed}");
                }
            }
            else
            {
                Console.WriteLine("Galleryde bu suret intervalinda masin yoxdur.");
            }

            Console.WriteLine("=============================");

            

        }
    }
}