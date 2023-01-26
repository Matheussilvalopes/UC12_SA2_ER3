using System;
using System.Threading;

namespace Encontro_Remoto_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Endereco end = new Endereco();
            end.logradouro="Rua X";
            end.numero=100;
            end.complemento="Bl. 45 apt. 229";
            end.enderecoComercial= true;

            Endereco endPF= new Endereco();
            endPF.logradouro="Rua Y";
            endPF.complemento="Bl. 4 apt. 6054";
            endPF.numero= 0;
            endPF.enderecoComercial= false;

            PessoaJuridica empresa = new PessoaJuridica();
            empresa.cnpj= 2345345561232;
            empresa.nome="Investimentos";
            empresa.razaoSocial="Soluções Investimentos";
            empresa.endereco= end;
            
            PessoaFisica pf=new PessoaFisica();
            pf.cpf= "123.234.456-78";
            pf.dataNascimento= new DateTime(1997, 01, 13);
            pf.endereco= endPF;
            pf.nome="Matheus Lopes";

            Console.WriteLine($"Rua: {empresa.endereco.logradouro}, {empresa.endereco.numero}");

            Console.WriteLine($"Sua data de nascimento é: {pf.dataNascimento}");

            bool idadeValida= pf.ValidarDataNascimento(pf.dataNascimento);
            Console.WriteLine(idadeValida);

            if(idadeValida==true){
                System.Console.WriteLine($"Cadastro Aprovado");
            }else{
                System.Console.WriteLine($"Cadastro Reprovado");
            }



        } 
    }
    
}

