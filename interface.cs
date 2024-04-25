using System;

interface IAtaque {
    void Atacar();
}

class Guerreiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("guerreiro ataca com espada!");
    }
}

class Mago : IAtaque {
    public void Atacar(){
        Console.WriteLine("Mago lança bola de fogo!");
    }
}

class Argueiro : IAtaque{
    public void Atacar(){
        Console.WriteLine("Argueiro dispara flechas!");
    }
}
class Program {
    static void Main(string[] args){

        IAtaque guerreiro = new Guerreiro();
        IAtaque mago = new Mago();
        IAtaque argueiro = new Argueiro();
    
    }
}