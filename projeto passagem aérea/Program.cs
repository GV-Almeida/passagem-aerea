// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1 - Cadastrar passagem
// 2 - Listar Passagens
// 0 - Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


Console.WriteLine($"Informe a senha para acessar o menu do Passagens.com: ");
string senha = Console.ReadLine();
    
while (senha != "123456")
{
    Console.WriteLine($"Informe uma senha válida: ");
    senha = Console.ReadLine();
}

 Console.WriteLine($"Acessando o Menu Passagens.com!");


 Console.WriteLine(@$" 1 - Cadastrar passagem
 2 - Listar passagem
 0 - Sair");
 char opcao = char.Parse(Console.ReadLine());

 while(opcao != '1' && opcao != '2' && opcao != '0')
 {
    Console.WriteLine(@$"Selecione uma opcao válida!
 1 - Cadastrar passagem
 2 - Listar passagem
 0 - Sair");
    opcao = char.Parse(Console.ReadLine());
 }

 

string[] cadastro = new string [4];

 if(opcao == '1')
 {

    for (int i = 0; i <= 3; i++)
    {
    
        
    Console.WriteLine($" {i + 1}º Informe o nome do passageiro: ");
     cadastro[0] = Console.ReadLine();

    Console.WriteLine($"Origem do voo do {i + 1}º passageiro: ");
    cadastro[1] = Console.ReadLine();

    Console.WriteLine($"Destino do voo do {i + 1}º passageiro: ");
    cadastro[2] = Console.ReadLine();

    Console.WriteLine($"Informe a data do voo do {i + 1}º passageiro (dd/mm/aaaa): ");
    cadastro[3] = Console.ReadLine();
    
    }
 }
 if(opcao == '2')
 {
    Console.WriteLine($"Nenhum voo cadastro em nosso sistema!");
    
    Console.WriteLine(@$" 1 - Cadastrar passagem
 2 - Listar passagem
 0 - Sair");
 opcao = char.Parse(Console.ReadLine());

    if(opcao == '1')
    {
         for (int i = 0; i <= 3; i++)
    {
    Console.WriteLine($" {i + 1}º Informe o nome do passageiro: ");
     cadastro[0] = Console.ReadLine();

    Console.WriteLine($"Origem do voo do {i + 1}º passageiro: ");
    cadastro[1] = Console.ReadLine();

    Console.WriteLine($"Destino do voo do {i + 1}º passageiro: ");
    cadastro[2] = Console.ReadLine();

    Console.WriteLine($"Informe a data do voo do {i + 1}º passageiro (dd/mm/aaaa): ");
    cadastro[3] = Console.ReadLine();
    }
     }

 if(opcao == '0')
 {
    Console.WriteLine($"Informe a senha para acessar o menu do Passagens.com: ");
    senha = Console.ReadLine();
    
while (senha != "123456")
{
    Console.WriteLine($"Informe uma senha válida: ");
    senha = Console.ReadLine();
}
 }
 
}