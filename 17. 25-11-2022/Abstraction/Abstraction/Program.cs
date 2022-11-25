namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new();
            cat.Age = 1;
            cat.ClassName = "Iranian";
            cat.Gender = "male";
            cat.MakeSound();
            cat.Eat();

            Dog dog = new();

            dog.MakeSound();
            dog.Eat();

            DomesticCat domesticCat = new DomesticCat();
            domesticCat.MakeSound();

        }
    }
}