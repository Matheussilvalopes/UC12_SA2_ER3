using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2
{
    public class PessoaJuridica : Pessoa
    {
        public long cnpj {get; set;}
        public string? razaoSocial {get; set;}

        public override void PagarImposto(float salario){

        }
        
    }
}