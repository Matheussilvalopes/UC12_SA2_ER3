using System;
using System.Threading;

namespace Encontro_Remoto_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<PessoaFisica> ListaPF = new List<PessoaFisica>();
            List<PessoaJuridica> ListaPJ= new List<PessoaJuridica>();
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.BackgroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine(@$"
========================================
|  Bem-vindo ao sistema de cadastro    |
|  de pessoa física e pessoa jurídica  |
========================================
");
            BarraCarregamento("Iniciando");
            
            string? opcao;
            do
            {
            Console.WriteLine(@$"
=====================================
|   Escolha uma das opções abaixo:  |
|                                   |
|       Pessoa Física               |
|    1- Cadastrar Pessoa Física     |
|    2- Listar Pessoa Física        |
|    3- Remover Pessoa Fisica       |
|                                   |
|       Pessoa Jurídica             |
|    4- Cadastrar Pessoa Jurídica   |
|    5- Listar Pessoa Jurídica      |
|    6- Remover Pessoa Jurídica     |
|                                   |
|    0-Sair                         |
=====================================
");
                opcao=Console.ReadLine();
                switch (opcao)
                {
                    case "1":                        

                        PessoaFisica pf= new PessoaFisica();
                        
                        Console.WriteLine($"Digite o o seu CPF.");
                        pf.cpf=Console.ReadLine();
                        
                        Console.WriteLine($"Digite o seu nome.");
                        pf.nome=Console.ReadLine();

                        Console.WriteLine($"Digite a sua data de nascimento.");
                        pf.dataNascimento= DateTime.Parse(Console.ReadLine());
                        
                        Endereco endPF= new Endereco();
                        
                        Console.WriteLine($"Digite seu logradouro.");
                        endPF.logradouro=Console.ReadLine();

                        Console.WriteLine($"Digite o número.");                        
                        endPF.numero=int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento.");                        
                        endPF.complemento=Console.ReadLine();
                        
                        
                        enderecoComercial(endPF);
                        
                        pf.endereco= endPF;


                        Console.WriteLine($"Digite o seu salário.");
                        pf.salario=int.Parse(Console.ReadLine());

                        // Console.WriteLine($"O desconto do Imposto é: {pf.PagarImposto(pf.salario)} reais");
                        // Console.WriteLine($"Sua data de nascimento é: {pf.dataNascimento}");

                        bool idadeValida= pf.ValidarDataNascimento(pf.dataNascimento);
                        
                        if(idadeValida==true){
                            System.Console.WriteLine($"Cadastro Aprovado");
                            ListaPF.Add(pf);
                            Console.WriteLine($"O desconto do Imposto é: {pf.PagarImposto(pf.salario)} reais");
                        }else{
                        System.Console.WriteLine($"Cadastro Reprovado");
                        }

                        break;
                    case "2":
                        foreach (var cadaitem in ListaPF)
                        {
                            Console.WriteLine($"{cadaitem.nome},{cadaitem.cpf},{cadaitem.endereco.logradouro},{cadaitem.endereco.numero},{cadaitem.dataNascimento}");
                        }
                        break;
                    case "3":
                        Console.WriteLine($"Qual CPF desejas remover?");
                        string cpfprocurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada =ListaPF.Find(cadaitem => cadaitem.cpf==cpfprocurado);
                        if( pessoaEncontrada != null){
                            ListaPF.Remove(pessoaEncontrada);
                            Console.WriteLine($"CPF removido com sucesso!");

                        }else{
                            Console.WriteLine($"CPF não encontrado.");
                        }

                        break;
                    case "4":
                        
                        PessoaJuridica pj = new PessoaJuridica();

                        PessoaJuridica novapj = new PessoaJuridica();
                        
                        Console.WriteLine($"Digite o seu CNPJ.");
                        novapj.cnpj= Console.ReadLine();

                        Console.WriteLine($"Digite o seu nome.");
                        novapj.nome=Console.ReadLine();

                        Console.WriteLine($"Digite a razão social da sua empresa.");
                        novapj.razaoSocial=Console.ReadLine();

                        //inicio endereço pj
                        Endereco endPJ= new Endereco();
                        
                        Console.WriteLine($"Digite seu logradouro.");
                        endPJ.logradouro=Console.ReadLine();

                        Console.WriteLine($"Digite o número.");                        
                        endPJ.numero=int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento.");                        
                        endPJ.complemento=Console.ReadLine();
                        
                        enderecoComercial(endPJ);
                        novapj.endereco= endPJ;
                        //fim endereço pj

                        Console.WriteLine($"Digite o rendimento da companhia.");
                        novapj.salario=float.Parse(Console.ReadLine());
                       
                        // Console.WriteLine($"O desconto do Imposto é: {pj.PagarImposto(novapj.salario)} reais"); Verificação da conta do método PagarImposto();
                        // Console.WriteLine($"Rua: {novapj.endereco.logradouro}, {novapj.endereco.numero}");

                        bool cnpjValido= pj.ValidarCnpj(novapj.cnpj);
                        if(cnpjValido==true){
                            Console.WriteLine($"CNPJ cadastrado com sucesso!");
                            ListaPJ.Add(novapj);
                            Console.WriteLine($"O desconto do Imposto é: {pj.PagarImposto(novapj.salario)} reais");
                        }else{
                            Console.WriteLine($"CNPJ não cadastrado, digite um CNPJ válido.");
                            // Console.WriteLine($"{novapj.cnpj.Substring(8,4)}"); Verificação das premissas utilizadsas em ValidarCnpj
                            // Console.WriteLine($"{novapj.cnpj.Length}"); Verificação das premissas utilizadas em ValidarCnpj
                        }
                        break;
                    case "5":
                        foreach (var cadaitem in ListaPJ)
                        {
                            Console.WriteLine($"{cadaitem.nome},{cadaitem.cnpj},{cadaitem.endereco.logradouro},{cadaitem.endereco.numero},{cadaitem.razaoSocial}");
                        }
                        break;
                    case "6":
                        Console.WriteLine($"Qual CNPJ desejas remover?");
                        string cnpjprocurado = Console.ReadLine();
                        PessoaJuridica pjEncontrada =ListaPJ.Find(cadaitem => cadaitem.cnpj==cnpjprocurado);
                        if( pjEncontrada != null){
                            ListaPJ.Remove(pjEncontrada);
                            Console.WriteLine($"CNPJ removido com sucesso!");

                        }else{
                            Console.WriteLine($"CNPJ não encontrado.");
                        }
                        break;

                    case "0":
                        Console.WriteLine($"Obrigado por utilizar nosso sistema!");
                        BarraCarregamento("Finalizando");
                        break;
                    default:
                    Console.WriteLine($"Opção inválida, digite uma opção válida");
                        break;
                }
            } while (opcao !="0");

        } 
    static void BarraCarregamento(string textoCarregamento){
            
            Console.ResetColor();
            Console.Write(textoCarregamento);
            Thread.Sleep(500);

            for (int contador = 0; contador < 10; contador++)
            {
             Console.Write($".");   
             Thread.Sleep(500);
            }

            Console.ResetColor();
        }
    static bool enderecoComercial(Endereco end){
        Console.WriteLine($"Este endereço é comercial? S/N");
        string resposta= Console.ReadLine().ToUpper();
        if(resposta=="S"){
            return end.enderecoComercial=true;
        }else{
            return end.enderecoComercial=false;
        }
    }

    }
    
    
}

