using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class User
    {

        public static int Counter; //1 -> 2
        public int Id { get; set; } // 0
        public string Username { get; set; }
        public string Password { get; set; }

        static User()
        {
            Counter = 0;
        }

        public User()
        {
            Counter++; //2
            Id = Counter; // 1 -> 2 
        }

        public static bool CheckPassword(string value)
        {
            if(!string.IsNullOrWhiteSpace(value) && char.IsUpper(value[0]) && value.Length > 7) return true;

            return false;
        }
    }
}
