using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using _08_AtributosCustomizados;

namespace _08_Atributos_Reflections
{
    class Usuario
    {
        [Required(ErrorMessage =  "O Campo 'Nome' é de preenchimento obrigatório")]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MyValidationAttribute(ErrorMessage ="O Campo Senha deve conter exatamente 10 caracteres")]
        public string Senha { get; set; }

    }
}
 