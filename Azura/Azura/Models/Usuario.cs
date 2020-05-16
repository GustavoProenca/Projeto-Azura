using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Azura.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string NomeUsuario { get; set; }
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
    }
}
