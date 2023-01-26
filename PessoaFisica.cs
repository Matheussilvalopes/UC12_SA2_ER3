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
        public override void PagarImposto(float salario){} 
        //override é o atributo de classe que faz com que, quando utilizado, sobrescreva outro atributo com mesmo nome,
        //nesse caso, um método geralmente abstrata, como o método PagarImposto na classe Pessoa é abstrato, ele não pode ser instanciado
        //não pode ter um corpo, sendo assim, é necessário utilizar o override dentro da classe PF e PJ com o método PagarImposto para
        //qeu possamos criar um corpo e uma forma para ele. 
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