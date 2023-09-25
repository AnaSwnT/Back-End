using Models;

public class Program 
{
    public static void Main()
    {
        //Criando um objeto da classe Pessoa
        //Instaciando sem um método construtor
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Ana Carolina";
        pessoa1.idade = 16;
        pessoa1.Cantar();
    }

    //Alternativa para criação de um objeto sem construtor
    Pessoa pessoa2 = new Pessoa{
        nome = "Ana Carolina",
        idade = 16
    };
    

    pessoa2.Cantar(); 
    */ 
    Pessoa pessoa1 = new Pessoa("Ana Carolina", 16, "ana.santiago@portalsesisp.org.br");
    pessoa1.Cantar();
    pessoa1.Descricao();

    Pessoa pessoa2 = new Pessoa("Adalberto Kaio", 16, "adalberto.kaio@portalsesisp.org.br");
    pessoa2.Cantar();
    pessoa2.Descricao();
    
    Pessoa pessoa3 = new Pessoa("Bruna Dutra", 17, "bruna.salamancas@portalsesisp.org.br");
    pessoa3.Cantar();
    pessoa3pu.Descricao();
}
}
