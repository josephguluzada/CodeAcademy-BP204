namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();

            Console.WriteLine(areaCalculator.Area(new Circle { Radius = 10}));
            Console.WriteLine(areaCalculator.Area(new Triangle { Side = 3, Height=4}));
            Console.WriteLine(areaCalculator.Area(new Rectangle { Width = 3, Height=4}));
        }
    }
}