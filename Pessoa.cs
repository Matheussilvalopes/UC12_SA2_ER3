using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2
{
    public abstract class Pessoa
    {
        public string? nome{get;set;}
        //get e set são métodos, técnicas padronizadas para  gerenciamento de acesso de uso, 
        //o get é a possibilidade de visualizar e o set é de alterar o atributo
        public Endereco? endereco { get; set; }
        //Apesar de já existir a classe Endereço, a mesma irá compor o ATRIBUTO endereço dentro da classe abstrata Pessoa
        //depois de definir a classe como public ou private, temos que definir qual será o tipo do atributo, e assim, colocando 
        //o tipo como Endereco, "puxamos" a classe Endereco para definir o atributo endereco, fazendo assim a composiçõa de classes.
        public abstract float PagarImposto(float salario);
        // void é quando não vamos utilizar o retorno em nenhum lugar do código, caso deseje a aplicação, podemos definir o retorno como:
        //string, int, boll, etc
        // Colocar um método como abstract nos permite utilizar a função polimórfica, onde definimos a base do método utilizado no sistema
        //e definiremos suas características únicas dentro das classes em que será utilizado
    
    }
    // A classe Pessoa não pode ser instanciada porque ela é utilizada para reutilização do código, ela em si não represneta nada.
    //Porem, as informações dela JUNTO com as informações das classes Pessoas Físcas e Jurídicas que fazem o objeto Pessoa

}