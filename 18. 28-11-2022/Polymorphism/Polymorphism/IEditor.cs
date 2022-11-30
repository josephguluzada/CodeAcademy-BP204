using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal interface IEditor
    {
        void Create();
        void Edit(int id);
    }
}
