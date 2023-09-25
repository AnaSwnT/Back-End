Console.WriteLine("Digite o valor de x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y");
int y = int.Parse(Console.ReadLine());

//Exemplos de operadores aritméticos 
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //Calculando o resto da divisão de x por 2
int restoYDiv2 = y % 2;

//Console para exibir na tela as variaveis em cada linha
//Soma: 15
Console.WriteLine($"soma: {soma}");
Console.WriteLine($"subtração: {subtracao}");
Console.WriteLine($"divisão: {divisao}");
Console.WriteLine($"multiplicação: {multiplicacao}");
Console.WriteLine($"resto: {resto}");

if (restoDiv2 == 0)
{
    Console.WriteLine($"O número {x} é par");
} 
else
{
    Console.WriteLine($"O número {x} é impar");
}
if (restoYDiv2 == 0)
{
    Console.WriteLine($"O número {x} é par"); 
}
else {
    Console.WriteLine($"O número {x} é impar");
}

//Operador ternário
//Condição ? se verdade: senão
string resultado = (restoDiv2 == 0 ) ? $"O número {x} é par" : $"O número {x} é impar"

int diaSemana = 3;
//Aprendendo Switch Case 
switch (diaSemana)
{
    case 1:
    Console.WriteLine("Hoje é domingo!");
    break;
    case 2:
    Console.WriteLine("Hoje é segunda!");
    break;
    case 3: 
    Console.WriteLine("Hoje é terça!");
    break;
    case 4: 
    Console.WriteLine("Hoje é quarta!");
    break;
    case 5:
    Console.WriteLine("Hoje é quinta!");
    break;
    case 6:
    Console.WriteLine("Hoje é sexta!");
    break;
    case 7:
    Console.WriteLine("Hoje é sábado!");
    break;
    default:
    Console.WriteLine("Dia inválido");   
    break;
}