public abstract class Persoangem {
    public string Nome { get; set; }
    public int Vida { get; set; }
    public Persoangem(string nome, int vida) {
        Nome = nome;
        Vida = vida; 
}
public abstract void Atacar();
public void ReceberDano(int dano) {
    Vida = dano;
    Console.WriteLine($"{nome} recebeu {dano} de dano e agora tem {Vida} de vida.");
    if (Vida <= 0) {
        Morrer();
    }
}
public void Morrer() {
    Console.WriteLine($"{Nome} morreu!");
}
}
public class Guerreiro : Persoangem {
    public Guerreiro(string nome, int vida) : base(nome, vida){}
    public override void Atacar(){
    Console.WriteLine($"{Nome} ataca com sua espada!");
    }
}
public class Mago : Persoangem {
    public Mago(string nome, int vida) : base(nome, vida){}

    public override void Atacar() {
        Console.WriteLine($"{Nome} lança um feitiço mágico!");
    }
}
    
    

        
