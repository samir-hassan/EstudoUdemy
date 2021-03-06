﻿using _08_Atributos_Reflections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AtributosCustomizados
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usu = new Usuario { Nome = "Samir", Senha = "123456789", Email = "Samir" };

            ValidationContext contexto = new ValidationContext(usu);
            List<ValidationResult> resultados = new List<ValidationResult>();

            // O ultimo true passado como argumento - Valide todas as propriedades
            bool verificacao = Validator.TryValidateObject(usu, contexto, resultados, true);

            if (!verificacao)
            {
                resultados.ForEach(a => Console.WriteLine(a));
            }

            Console.Read();
        }
    }
}
