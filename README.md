# Aplicação Cadastro de Pessoas Físicas e Jurídicas
Este é um aplicativo de cadastro de pessoas jurídicas e físicas e tem como objetivo o aprendizado da linguagem C#
## Funcionalidades
A aplicação nos traz um menu, onde o usuário pode escolher cadastrar, listar ou remover, tento Pessoas Físicas quanto Pessoas Jurídicas
ficando, as  funcionalidades, nessa ordem:
    
    1. Cadastrar Pessoa Física
    2. Listar Pessoas Físicas
    3. Remover Pessoa Física
    4. Cadastrar Pessoa Jurídica
    5. Listar Pessoa Jurídica
    6. Remover pessoa Jurídica

Além disso, o app tem a capacidade de criar arquivos personalizados em pastas específicas, tanto para Pessoa Jurídica quanto para Pessoa Física registrando os respectivos nomes de cadastro, endereços, rendimentos, etc.
## Tecnologias
A tecnologia utilizidada foi o @VisualStudioCode, uma IDE completa para a compilação e desenvolvimento em linguagem @C#, esta sendo a única linguagem utilizada na aplicação. 
## Organização do Projeto
O projeto primeiramente foi pensado no papel, organizando as funcionalidades e as relações possíveis entre as classes e os objetos da aplicação medidante um método agil e uma documentação UML.
Logo após começamos de fato a programação, primeiramente sobre a Classe abstrata *Pessoas.cs* e seus atributos e métodos abstratos e posteriormente as suas herdeiras, as classes **PessoaFísica.cs** e **PessoaJuridica.cs**.
Em seguida, programamos em definitivo para o usuário, utilizando o terminal como porta de entrada das informações necessárias do usuário para fazer a aplicação rodar. Lógica de programação e OOP foram fortemente utilizados para a construção desse projeto.
## Pré-requisitos de Instalação
Penso como pré-requisitos o interessado ter em sua máquina instalados o @VSCode e a linguagem de programação C#, incluindo a intalação de algumas extensões no @VSCode, como C# Extensions, C# Snippets e C# XML Documentation,  junto com o framework @.NET 6.0.

## Execução do Aplicativo
Para a execução da aplicação, como estamos utilizando o framework .NET 6.0 utilizamos o comando `dotnet run` no terminal do @VSCode para executá-lo. Lembre-se para abrir o terminal podemos utilizar o atalho `Ctrl + Shift + '`.
## Erros Comuns
Alguns erros podem ocorrer na aplicação. Para funcionar e o usuário conseguir cadastrar de fato os dados da Pessoa Física ou Jurídica
alguns requisitos serão necessários:

    1. Pessoa Física
    
        * A pessoa cadastrada precisa ter mais de 18 anos (nascido até 2004)
        * A data de nascimento __precisa__ ter a / entre os dias meses e anos (Ex.: XX/XX/XXXX)
        * Renda e Número do endereço necessitam ser precisamente números
    
    2. Pessoa Jurídica
        * O CNPJ precisa ter 14 números exatos!
        * Os 4 antepenúltimos números do CNPJ precisam ser 0001, foi assim que validamos o CNPJ. (Ex.: 12334567 **0001** 34)
        * Renda e Número do endereço necessitam ser precisamente números

Verifique todos esses requisitos para ter certeza que o erro não é do código e sim das informções adicionadas no terminal. Se ocorrer algum erro que não esteja listado, provavelmente é um erro de instalação, lembre-se de instalar as extensões mostradas na parte **Pré-requisitos de Instalação** deste README.md. Se não for nada além disso consulte [Como clonar e usar um repositório do Github no VSCode](https://learn.microsoft.com/pt-br/azure/developer/javascript/how-to/with-visual-studio-code/clone-github-repository?tabs=create-repo-command-palette%2Cinitialize-repo-activity-bar%2Ccreate-branch-command-palette%2Ccommit-changes-command-palette%2Cpush-command-palette)

## Contribuidores
Matheus da Silva Lopes