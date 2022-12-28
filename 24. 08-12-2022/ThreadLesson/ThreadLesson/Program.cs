namespace ThreadLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);
            //Thread thread3 = new Thread(Loop3);
            //thread1.Start();
            //Console.WriteLine("salam");
            //thread1.Join();
            //Console.WriteLine("Eleykum");
            //thread2.Start();
            //thread3.Start();

            Program program = new Program();

            

            Thread thread1 = new Thread(program.Increment);
            Thread thread2 = new Thread(program.Decrement);

            thread2.Start();
            thread1.Start();
            thread2.Join();
            thread1.Join();

            Console.WriteLine(program.Counter);
        }

        public int Counter { get; set; }
        private object LockObj1 = new object();
        private object LockObj2 = new object();

        public void Increment()
        {
            for (int i = 0; i < 100000000; i++)
            {
                lock (LockObj1)
                {
                    lock (LockObj2)
                    {
                        Counter++;
                    }
                }
            }
        }

        public void Decrement()
        {
            for (int i = 0; i < 100000000; i++)
            {
                lock (LockObj2)
                {
                    lock (LockObj1)
                    {
                        Counter--;
                    }
                }
            }
        }



        private static void Loop2()
        {
            //for (int i = 100; i < 200; i++)
            //{
            //    Console.Write(i + " ");
            //}
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(500);
                Console.Write("B");
            }
        }

        //private static void Loop3()
        //{
        //    //for (int i = 100; i < 200; i++)
        //    //{
        //    //    Console.Write(i + " ");
        //    //}
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Thread.Sleep(600);
        //        Console.Write("C");
        //    }
        //}

        private static void Loop1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(400);
                Console.Write("A");
            }
        }
    }
}