using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class UserCRUD
    {
        public void Create(User user)
        {
            Database.Users.Add(user);
        }

        public void Delete(User user)
        {
            Database.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return Database.Users;
        }
    }
}
