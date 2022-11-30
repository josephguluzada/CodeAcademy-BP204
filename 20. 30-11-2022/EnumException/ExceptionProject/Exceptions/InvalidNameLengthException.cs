using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject.Exceptions
{
    internal class InvalidNameLengthException : Exception
    {
        public InvalidNameLengthException(string? message) : base(message)
        {

        }
    }
}
