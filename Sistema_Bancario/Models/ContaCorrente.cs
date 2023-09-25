namespace Models
{

    public class ContaCorrente
    {
        private string nome { get; set; }

        private double saldo { get; set; }

        public ContaCorrente ( string nomeContaCorrente)
        {
            this.nome = nomeContaCorrente;
            this.saldo = 100;
        } 

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é de R${saldo}");
        }

        public void Depositar()
        {
            Console.WriteLine("Digite o valor do seu depósito");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Valor depositado com sucesso.");
            }
            else 
            {
                Console.WriteLine("Valor de saldo inválido.");
            }
        }

        public void Sacar()
        {
            Console.WriteLine("Digite o valor do seu saque");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0 && saldo >= valor ) {
                saldo -= valor;
            } 
            else {
                Console.WriteLine("Valor de saque inválido ou indisponível");
            }
            }
        

    }
    }