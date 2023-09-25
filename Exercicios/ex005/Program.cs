public static void ListaSonhos()
{
    string[] sonhos = new string{3};
    decimal[] valores = new decimal[3];

    for (int i = 0; i < 3; i++){
        Console.WriteLine($"Informe o seu {i}º sonho");
        string sonho = Console.ReadLine();
        Console.WriteLine($"Informe o valor do {i}º sonho");
        decimal valor = decimal.Parse(Console.ReadLine());
        sonhos[i] = sonho;
        valores[i] = valor;
    }

    foreach (decimal val in valores)
    {
        total = total + val;
    }
    Console.WriteLine($"Seus sonhos custarão aprox. R${total}");
}