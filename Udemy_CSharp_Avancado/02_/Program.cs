using _02_;
using _02_.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics

            Generics generics = new Generics();
            //generics.Execute();

            #endregion

            #region Extension Methods

            //ExtensionMethods.Execute();

            #endregion

            #region Nullable

            //Podemos colocar a variavel idade com valor nulo
            int? idade = null; 

            #endregion
        }
    }
}
