// Definição da classe
public class Carro
{
    // Propriedades da classe
    private  string Marca { get; set; }
    private string Modelo { get; set; }
    private int Ano { get; set; }

    // Construtor da classe
    public Carro(string marca, string modelo, int ano)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
    }

    // gerar modificadores de acesso get e set 
    // Método para exibir informações do carro
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
}

class Program  
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe Carro
        Carro meuCarro = new Carro("Toyota", "Corolla", 2022);

        // Chamando o método para exibir informações do carro
        meuCarro.ExibirInformacoes();
    }
}
// subclass 2 
public string onix:civic 
{
    //atribudo especifico do onix 

    public string marca {get;set; }

    //contrutor
    public onix(string marca, string modelo string ano)
    :base(marca,modelo,ano)
    {
        marca - material;
    }

    //metodo especifico do onix 
    public void Exibirmarca()


    //metodo especifico
}
