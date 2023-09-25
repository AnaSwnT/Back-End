Console.WriteLine("Digite o valor da sua placa");
string placas = (Console.ReadLine());

string ultimo = placas.Substring(placas.Length-1, 1);

Console.WriteLine($"o final da sua placa é {ultimo}");

if (ultimo == "1" || ultimo == "2") {
    Console.WriteLine("você não pode andar na segunda-feira");
}
else if (ultimo == "3" || ultimo == "4") {
    Console.WriteLine("você não pode andar na terça-feira");
}
else if (ultimo == "5" || ultimo == "6") {
    Console.WriteLine("você não pode andar na quarta-feira");
}
else if (ultimo == "7" || ultimo == "8") {
    Console.WriteLine("você não pode andar na quinta-feira");
}
else if (ultimo == "9" || ultimo == "0") {
    Console.WriteLine("você não pode andar na sexta-feira");
}