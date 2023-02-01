using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj {get; set;}
        public string? razaoSocial {get; set;}

        public float salario{get; set;}

        public override float PagarImposto(float salario){
            if(salario<=5000){
                return (salario/100)*6;
            }else if(salario>5000 && salario<=10000){
                return (salario/100)*8;
            }else{
                return (salario/100)*10;
            }
        }
        public bool ValidarCnpj(string cnpj){
            
            if( cnpj.Length == 14  && cnpj.Substring(8,4)=="0001"){
                return true;
            }else{
                return false;
            }
        }
    }
}