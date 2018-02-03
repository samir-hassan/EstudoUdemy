using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_
{
    public static class stringExtension
    {
        public static string FirstToUpper(this String str)
        {
            var primeiraMaiusculo = str[0].ToString().ToUpper();
            str = primeiraMaiusculo + str.Substring(1, str.Length - 1);

            return str;
        }
    }
}
