using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class User
    {

        private static int _counter;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        static User()
        {
            _counter = 0;
        }

        public User(string username, string password)
        {
            _counter++;
            Id = _counter;
            Username = username;
            Password = password;
        }

        
    }
}
