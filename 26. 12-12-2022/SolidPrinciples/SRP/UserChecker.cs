using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class UserChecker
    {
        public bool CheckPassword(string password)
        {
            if (String.IsNullOrWhiteSpace(password) || password.Length > 20 || password.Length < 5)
                return false;
            return true;
        }

        public bool CheckUsername(string username)
        {
            if (String.IsNullOrWhiteSpace(username) || username.Length > 20 || username.Length < 5)
                return false;
            return true;
        }

        public bool CheckEmail(string email)
        {
            if (String.IsNullOrWhiteSpace(email) || email.Length > 20 || email.Length < 5)
                return false;
            return true;
        }
    }
}
