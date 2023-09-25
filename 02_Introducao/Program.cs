// Somente declarando uma variável do tipo inteira e sem valor 
//int num1; 

//Declarando uma variável do tipo inteiro e atribuindo valor 5
//int num2 = 5;

//Declarando variável string
//string nomeAluno = "Henrique Alves"

//Variável do tipo lógico (true ou false)
//bool resultado = true

//nunca usar vírgula, sempre ponto. (em números)//


//Variável do tipo double valor com várias casas decimais
//double coordenada = 1.996547028;

//Variável do tipo decimal - utilizada para valores
//decimal valor = 1.80M;

int idade = 16;
string meuNome = "Ana Carolina"; //ValorPedidoTotal
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine("Em qual cidade você nasceu?");
//ReadLine serve apenas para que eu receba uma informação do usuário
//e armazeno em uma variável 
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");