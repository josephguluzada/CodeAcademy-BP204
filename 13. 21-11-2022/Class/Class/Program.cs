namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //car.Brand = "BMW";
            //car.Model = "F10";
            //car.CurrentFuel = 100;
            //car.FuelFor1Km = -10;
            car.Millage = 5;
            car.FuelFor1Km = 100;

            Console.WriteLine(car.FuelFor1Km);
            Console.WriteLine(car.Millage);
            //car.Drive(10);
            //car.Drive(5);

            //car.FuelFor1KmSetter(110);
            //Console.WriteLine(car.FuelFor1KmGetter());

            //car.ShowInfo();

        }
    }
}