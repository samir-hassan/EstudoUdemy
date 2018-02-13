using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AtributosCustomizados
{
    class MyValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string ObjToString = (string)value;

            if (ObjToString.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
