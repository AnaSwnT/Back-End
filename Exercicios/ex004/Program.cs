class Program {
    public static void Main()
    {       
        int divisao = Divisao(int.Parse (Console.ReadLine()) );
        Console.WriteLine ($"Divisao {divisao}");

        int multiplicacao =(int.Parse (Console.ReadLine()));
        double valor = Multiplicacao (multiplicacao);
        Console.WriteLine ($"O dobro é {valor}");

        Tabuada(int.Parse (Console.ReadLine()));
        ResumoSalarios();

    }

    public static int Divisao(int num)
    {
        int resultado = num/2;
        return resultado;
    }
    
    public static double Multiplicacao(int num)
    {
        double resultado = num*2;
        return resultado;
    }

    public static void Tabuada(int num)
    {
        int contador = 1;
        while (contador <= 10 )
        {
            Console.WriteLine($"1 x {num} - {contador * num}");
            contador++;
        }
    }

    public static void ResumoSalarios()
    {
        int SomaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int SalarioEmpregado = 0;

        do {
            Console.WriteLine("Digite o salário do empregado");
            SalarioEmpregado = int.Parse(Console.ReadLine());

            SomaSalarios = SomaSalarios + SalarioEmpregado;

            if ( SalarioEmpregado > maiorSalario ) {
                maiorSalario = SalarioEmpregado;
            } 

            if(SalarioEmpregado < menorSalario){
                menorSalario = SalarioEmpregado;
            }
        } while (SalarioEmpregado > 0 );
        Console.WriteLine($"A soma dos salários é {SomaSalarios} o maior salário é {maiorSalario} e o menor salário é o {menorSalario}");
    }
}