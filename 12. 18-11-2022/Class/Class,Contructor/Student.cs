namespace Class_Contructor
{
    internal class Student : Human
    {
        public Student():base()
        {
            Console.WriteLine("Student Created");
        }

        public Student(double point,string name) : base(name)
        {
            this.Point = point;
        }

        public Student(double point, string name, string surname) : base(name,surname)
        {
            this.Point = point;
        }

        public Student(double point, double grant, string name,string surname) : base(name)
        {
            this.Point = point;
            this.Grant = grant;
        }


        public double Point;
        public double Grant;
    }
}
