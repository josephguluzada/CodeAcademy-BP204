namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region NumberConversion
            //double a = 2560000000000;
            //int b = (int)a;
            //Console.WriteLine(b);
            #endregion

            Animal animal1 = new Animal();
            Animal tiger = new Tiger();
            Animal bee = new Bee();

            Animal[] animals = { animal1, tiger, bee };

            foreach (Animal animal in animals)
            {
                if(animal is Tiger tiger1)
                {
                    tiger1.Destroy();
                }
                if(animal is Bee bee1)
                {
                    bee1.MakeHoney();
                }
            }

            int a = 1;

            bool b = bool.Parse(a.ToString());
            Console.WriteLine(b);

            //Tiger tiger1 = (Tiger)tiger;
            //Bee bee1 = (Bee)bee;
            //Tiger tiger2 = (Tiger)bee;
            //Bee bee2 = (Bee)tiger;

            //Tiger tiger2 = tiger as Tiger;
            //if(tiger2 != null)
            //{
            //    Console.WriteLine("Cevire bildim");
            //}
            //else
            //{
            //    Console.WriteLine("Cevire bilmedim");
            //}




        }
    }

    class Animal
    {
        public string Name { get; set; }
    }
    class Tiger : Animal
    {
        public void Destroy()
        {
            Console.WriteLine("Tiger destroys");
        }
    }
    class Bee : Animal
    {
        public void MakeHoney()
        {
            Console.WriteLine("Bee honeys");
        }
    }
}