using System;

   public abstract class Animal{

     public Animal(string nome,int idade) 
    {
        this.nome = nome;
        this.idade = idade;
    }

     public string GetNome(){
        return nome;
    }

    public void SetNome(string nome){
        this.nome = nome;
    }

    public int GetIdade(){
        return idade;
    }

    public void SetIdade(int Idade){
        this.nivel = idade;
    }
      
    public abstract void EmitirSom();
    
    public abstract void Mover();


    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo.");
    }

    
    public void Dormir()
    {
        Console.WriteLine($"{Nome} está dormindo.");
    }
}


class Cachorro : Animal
{
     public Cachorro(string nome,int idade, ) :base(nome,idade) {
     }
    public override void EmitirSom()
    {
        Console.WriteLine("Au! Au!");
    }

    
    public override void Mover()
    {
        Console.WriteLine("Cachorro está correndo.");
    }
}


class Gato : Animal        
{
 public Cachorro(string nome,int idade, ) :base(nome,idade){

 }
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }

    
    public override void Mover()
    {
        Console.WriteLine("Gato está pulando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Cachorro cachorro = new Cachorro("Cachorro", 3)
        Gato gato = new Gato("Gato", 10)
        
        
        cachorro.EmitirSom(); 
        cachorro.Mover();     
        cachorro.Comer();       
        cachorro.Dormir();    

        gato.EmitirSom();  
        gato.Mover();      
        gato.Comer();      
        gato.Dormir();     
    }
}