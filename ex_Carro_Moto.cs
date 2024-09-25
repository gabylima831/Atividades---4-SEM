using System;

public class Veiculo
{
    //Atributos
    private string Cor {get; set;}
    private string Marca {get; set;}
    private string Modelo {get; set;}
    public int Ano {get; private set;}
    
    //Construtor - referencia a si mesmo/ string = instância
    public Veiculo(string cor, string marca, string modelo, int ano){
        Cor = cor;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    //Métodos da Classe
    //Método para acelerar o veículo
    public virtual void Acelerar(){ //Pode ser acessado fora do contexto. virtual = é uma diretiva de abstração
        Console.WriteLine("O veículo está acelerando...");
    }
    //Método para frear:
    public virtual void Frear()
    {
        Console.WriteLine("O veículo está freando...");
    }
    
    //Exibir info:
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Cor: {Cor}, Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
    
}

public class Carro : Veiculo
{
    public int NumPortas {get; private set;}
    
    //Construtor da classe:
    public Carro(string cor, string marca, string modelo, int ano, int numPortas)
        : base (cor, marca, modelo, ano)
        {
            NumPortas = numPortas;
        }
    //Método para classe:
    public void AbrirPorta()
    {
        Console.WriteLine($"Abrindo as {NumPortas} portas do carro... ");
    }
    //Método para mostrar info:
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Número de portas: {NumPortas}");
    }
}
//Crie uma classe Moto com o atributo cilindradas e método DarGrau(), e sobrescrever o método MostrarInfo().
public class Moto : Veiculo
{
    public int Cilindradas { get; private set;}
    
    //Construtor
    public Moto(string cor, string marca, string modelo, int ano, int cilindradas)
        : base(cor, marca, modelo, ano)
    {
        Cilindradas = cilindradas;
    }
    
    //Método DarGrau:
    public void DarGrau()
    {
        Console.WriteLine(@"
                .-/c-.,::  
                (_)'==(_))");
    }
    
    //Método para mostrar info:
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Número de cilindradas: {Cilindradas}");
    }
}

//Classe Principal
public class Program
{
    public static void Main(string[] args)
    {
        //Criar objeto Carro:
        Carro meuCarro = new Carro("Rosa", "Toyota", 2010, 4);
        meuCarro.MostrarInfo();
        meuCarro.Acelerar();
        meuCarro.AbrirPortas();
        meuCarro.Frear();
        Console.WriteLine();
        
        Moto minhaMoto = new Moto("Ducati", "CB500", 2021, 500);
        minhaMoto.MostrarInfo();
        minhaMoto.Acelerar();
        minhaMoto.DarGrau();
    }
}