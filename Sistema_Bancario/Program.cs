using Models;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("* * * * * * * * * * * * * * * *");
        Console.WriteLine("       Bem vindo ao Banco do Sesi       ");
        Console.WriteLine("");
        Console.WriteLine("* * * * * * * * * * * * * * * *");
        Console.WriteLine("");
        Console.WriteLine("Escreva o nome do titular da conta");

        Menu();

    }

    public static void Menu()
    {

        string nome = Console.ReadLine();

        ContaCorrente ContaCorrente1 = new ContaCorrente(nome);

        string opcao = "";

        do
        {
            Console.WriteLine("1- Consultar saldo ");
            Console.WriteLine("2- Depositar ");
            Console.WriteLine("3- Sacar");
            Console.WriteLine("0- Sair");
            opcao = Console.ReadLine();
            Console.Clear();


            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Sistema fechado com sucesso.");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    ContaCorrente1.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite o valor que deseja depositar");
                    ContaCorrente1.Depositar();
                    break;
                case "3":
                    ContaCorrente1.Sacar();
                    break;
            }


        } while (opcao != "0");
    }
}