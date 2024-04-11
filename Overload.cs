public class Personagem {
    private String nome;
    private string poder;
    private string pontoVida ;
    private string pontoAtaque;

     public Naruto(string nome, string poder,string pontoVida,string pontoAtaque) {
       Nome = nome;
       Preco = poder;
       Ponto De Vida = pontoVida;
       Ponto De Vida = pontoAtaque;
    }

    public string Nome {
        get { return nome;}
        set { nome = value;}
    }
    public string Poder{
        get{ return poder ; } 
        set { poder = value ; }
    } 
    public string PontoVida  {
        get { return pontoVida ; }
        set { pontoVida = value ; }
    } 
     public string PontoAtaque  {
        get { return pontoAtaque ; }
        set { pontoAtaque = value ; }
     }
     public void Personagem(){
        console.WriteLine("promocao de 75%")
     }
      public void Personagem(double Desconto){
        console.WriteLine("30.00")
     }
} 

public void Atacar(){
        Console.WriteLine("ataque rapido");
    }
    public void Atacar(string habilidade ){
        Console.WriteLine("ataque rapido"+habilidade);
    }


public class Naruto: Personagem { 
 
   public Naruto(string nome, string poder,string pontoVida,string pontoAtaque) {
       Nome = nome;
       Preco = poder;
       PontoVida = pontoVida;
       PontoVida = pontoAtaque;
       
    } descriçao
    }
    public void Atacar(){
        Console.WriteLine("correr");
    }
    public void Atacar(string habilidade ){
        Console.WriteLine("rasegan"+habilidade);
    }


public class Program {

    public static void Main(string[] args) {
        Naruto naruto = new naruto();

        //Sobrecarga
        naruto.Atacar();//Chama o método Atacar() da classe derivada
        naruto.Atacar("rasegan"+investida);//Chama o método Atacar(string) da classe base
        //Sobrecarga
        
    }
}




