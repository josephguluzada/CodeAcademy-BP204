using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class SMS : IMessageSender
    {
        public void Send()
        {
            Console.WriteLine("Sended from SMS service");
        }
    }
}
