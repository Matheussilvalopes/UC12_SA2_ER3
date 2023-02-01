using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2
{
    public class PessoaFisica : Pessoa
    // PessoaFisica : Pessoa estamos definindo que a classe Pessoafísica HERDA os atributos da classe abstrata Pessoa,
    // o usuário irá ter contato de fato, com as classes PessoaFísica ou PessoaJurídica, e não com a classe Pessoa, esta servindo apenas
    // para compactar todos os atributos comuns das classes PF e PJ, fazendo o código ser mais limpo.
    {
        public string? cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public float salario{get; set;}
        public override float PagarImposto(float salario){
            if(salario<=1500){
                return 0;
            }else if(salario>1500 && salario<=5000){
                return (salario/100)*3;
            }else{
                return (salario/100)*5;
            }
        } 
        // Override é o atributo de classe que faz com que, quando utilizado, sobrescreva outro atributo com mesmo nome,
        //nesse caso, um método geralmente abstrata, como o método PagarImposto na classe Pessoa é abstrato, ele não pode ser instanciado
        //não pode ter um corpo, sendo assim, é necessário utilizar o override dentro da classe PF e PJ com o método PagarImposto para
        //que possamos criar um corpo e uma forma para ele. 
        public bool ValidarDataNascimento(DateTime dataNasc){
            DateTime dataAtual = DateTime.Today;
            double anos = ((dataAtual - dataNasc).TotalDays)/365;

            if(anos>=18){
                return true;
            }else{
                return false;
            }
            //Perceba que definimos o método como bool, ou seja o retorno do método somente pode ser true ou false, não gerando assim,
            //um erro de lógica
        }
    }
}