using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class Helpers
    {
        public static bool CheckPassword(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length > 7 && char.IsUpper(value[0]))
            {
                for (int i = 1; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i])) return true;
                }
            }
            return false;
        }
    }
}
