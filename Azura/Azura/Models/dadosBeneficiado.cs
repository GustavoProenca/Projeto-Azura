using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azura.Models
{
    public class dadosBeneficiado
    {
        public int id { get; set; }
        public char nome { get; set; }
        public char cpf { get; set; }
        
        public char nis { get; set; }
        public char endereco { get; set; }
        public char numero { get; set; }
        public int moradores { get; set; }
    }
}