using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _08_Atributos_Reflections
{
    class Usuario
    {
        [Required(ErrorMessage =  "O Campo 'Nome' é de preenchimento obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem2), ErrorMessageResourceName = "OBRIGATORIO"), EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        public string Senha { get; set; }

    }
}
 