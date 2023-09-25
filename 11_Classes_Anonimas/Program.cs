public class Program 
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };

        var pessoa2 = new {
            nome = "Maria", 
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos.");
        Console.WriteLine($"A pessoa1 é {pessoa2.nome} e tem o e-mail {pessoa2.email}.");

        //pessoa1.nome = "Douglas"

        //Criar 2 objetos de classe anônima de Carro

        var carro1 = new {
            marca = "Audi",
            modelo = "A3",
            ano = 2023
        };

        var carro2 = new {
            marca = "Porsche",
            modelo = "Panamera",
            ano = 2023
        };

        Console.WriteLine($"O carro {carro1.modelo} é do ano {carro1.ano} e da marca {carro1.marca}.");
        Console.WriteLine($"O carro {carro2.modelo} é do ano {carro2.ano} e da marca {carro2.marca}.");
    }
}