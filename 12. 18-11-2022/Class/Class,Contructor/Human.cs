namespace Class_Contructor
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Human()
        {

        }

        public Human(string name)
        {
            this.Name = name;
        }

        public Human(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }


        public string GetFullname()
        {
            return this.Name + " " + this.Surname;
        }

    }
}
