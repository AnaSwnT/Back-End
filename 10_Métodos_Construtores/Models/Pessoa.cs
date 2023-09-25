namespace Models
{
    public class Pessoa 
    {
        //Atributos da nossa classe Pessoa 
        private string nome { get; set; }
        private int idade { get; set; }
        
        private string email { get; set; }

        private int anoNascimento { get; set; }

        public Pessoa  (string nomePessoa, int idadePessoa, string emailPessoa)
        {
            
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }
        //Método da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Descricao()
        {
            Console.WriteLine($"{nome} tem {idade} e nasceu no ano {anoNascimento}. Seu e-mail é {email}");
        }
    }
    
}