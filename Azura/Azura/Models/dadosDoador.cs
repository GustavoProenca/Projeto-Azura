using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azura.Models
{
    public class dadosDoador
    {
        public int id { get; set; }

        public char nome { get; set; }
        public char cpf { get; set; }        
        public char telefone { get; set; }
        public char empresa { get; set; }
        public char cnpj { get; set; }
        public char endereco { get; set; }
        public char numero { get; set; }
    }
}