namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cheetah cheetah = new Cheetah();
            //Cat cat = new Cheetah();

            //Lion lion = new Lion();
            //Cat cat2 = new Lion();

            //Cat[] cats = { cat, cat2 };

            //IWildAnimal wildAnimal1 = new Lion();
            //IWildAnimal wildAnimal2 = new Cheetah();

            //IWildAnimal[] wildAnimals = { wildAnimal1, wildAnimal2 };

            //foreach (IWildAnimal item in wildAnimals)
            //{
            //    item.Destroy();
            //}
            //A  a = new A();
            //a.MehodA();
            //B b = new B();
            //b.MehodA();
            //b.MehodB();
            //C c = new C();
            //c.MehodA();
            //c.MehodB();
            //c.MehodC();

            IAdmin admin = new SliderService();
            admin.Delete(8);
            admin.Create();
            admin.Get(1);
            admin.GetAll();


            IEditor editor = new SliderService();
            editor.Edit(8);
            editor.Create();


        }
    }
    //class A
    //{
    //    public void MehodA()
    //    {
    //        Console.WriteLine("A");
    //    }
    //}
    //class B : A
    //{
    //    public void MehodB()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}
    //class C : B
    //{
    //    public void MehodC()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}

}