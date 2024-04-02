public class Pessoa {
    private String nome;
    private int idade;
    private String cpf;

    public Pessoa(string nome, int idade,string cpf) {
       Nome = nome;
       Idade = idade;
       CPF = cpf;
    }

    public string Nome {
        get { return nome;}
        set { nome = value;}
    }
    public int Idade{
        get{ return idade ; } 
        set { idade = value ; }
    } 
    public string CPF {
        get { return idade ; }
        set { cpf = value ; }
    } 
} 

public class Estudante : Pessoa {
    private string curso;

    public Estudante(string nome, int idade, string cpf, string curso): base (nome, idade, cpf){
        curso = curso 
    } 


    public string Curso{
        get { return curso;}
        set { curso = value;}
    } 
}

public class funcionario : Pessoa {
    private double salario;

    public double Bonus(){
        return salario * 0.1;
    }

    public funcionario(string nome, int idade, string cpf, double salario) : base(nome,idade,cpf){
        Salario = salario
    }


    public string Salario {
        get {return salario;}
        set {salario = value;}
    }
}

public class Diretor : funcionario {

    public Diretor(string nome, int idade,string cpf,double salario):base (nome,)idade,cpf,salario){
    } 

    public override double Bonus {
        return base.Bonus()+ 1000;
    } 
}
