Console.WriteLine("Qual seu nome?");
string meuNome = Console.ReadLine();

Console.WriteLine("Digite a nota 1");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3");
int z = int.Parse(Console.ReadLine());

int nota1 = x;
int nota2 = y;
int nota3 = z;

int soma = (nota1 + nota2 + nota3) /3;

if (soma >= 7)
{
    Console.WriteLine($"O(a) aluno(a) {meuNome} foi aprovado com a nota {soma}");
}else{
    Console.WriteLine($"O(a) aluno(a) {meuNome} foi reprovado com a nota {soma}");
}

