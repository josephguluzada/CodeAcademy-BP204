namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            ChangeNumber(a);

            Console.WriteLine(a);

            Human human = new Human();
            ChangeName(human);

            Human human1;

            Console.WriteLine(human.Name);
        }

        static void ChangeName(Human human)
        {
            human.Name = "Rasim";
        }
        static void ChangeNumber(int number)
        {
            number = 6;
        }
    }
}