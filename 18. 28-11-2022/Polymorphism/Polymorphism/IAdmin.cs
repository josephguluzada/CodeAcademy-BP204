using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal interface IAdmin
    {
        void Create();
        void Edit(int id);
        void Delete(int id);
        void DeleteAll();
        void Get(int id);
        void GetAll();  

    }
}
