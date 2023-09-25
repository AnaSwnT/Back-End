﻿//Clase Pai que será herdada pelo filho - SuperClasse
class Animal
{
    public string cor { get; set; }

    public void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}
//Classe filha que herdará da classe Animal 
//Receberá todos os atributos de métodos da SuperClasse

class Cachorro : Animal {

    public string tipoPelo { get; set; }
    public virtual void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo");
    }
}

class Gato : Animal {

    public override void EmitirSom()
    {
        Console.WriteLine("O gato está emitindo som");
    }
}


class Program 
{
    public static void Main()
    {
        //Não é permitido instanciar um objeto de uma classe abstrata 
        //Animal animalGenerico = new Animal();
        //animalGenerico.EmitirSom();

        
        Animal animalGenerico = new Animal();
        animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
        
}