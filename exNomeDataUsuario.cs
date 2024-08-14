//Diretiva com o System NameSpace (Conjunto de diretivas) - Classe onde se aloca bibliotecas de códigos para evitar conflitos de nome.

using System; 
using System.Text;
//; = final da linha. //import = traz objetos/using = reconhece objetos(funções e classes) que estão na diretiva.

public class HelloWorld// Classe - incorpora uma ou mais funções. pública = acessível para todos os códigos. /HelloWorld = objeto.  função = obj. em que se estabelece uma sequência.
//public, private, protected,internal, protected internal, private protected.
{//obj. no nível abaixo (dentro da classe).
    //Acessível em qualquer lugar:
    //()parâmetro com array de strings - conj. de palavras ordenadas.
    public static void Main(string[] args)//Método Main - Ponto/Código de Entrada. static = pertencimento (estático), faz o que a Classe HelloWorld comanda e funciona apenas dentro dessa classe.//void = método vazio (sem argumento), não retorna nenhum valor. Precisa ser executada. 
    {
        //Inserir caracteres especiais:
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine ("Olá, mundo!");//Console = é uma classe. Write Line(escreve uma linha).//Imprime letras e números.
    }
    //Acessível somente dentro da minha class HelloWorld:
    //private int PropriedadePrivada {get; set;}
}

using System; 
using System.Text;
//; = final da linha. //import = traz objetos/using = reconhece objetos(funções e classes) que estão na diretiva.

public class HelloWorld// Classe - incorpora uma ou mais funções. pública = acessível para todos os códigos. /HelloWorld = objeto.  função = obj. em que se estabelece uma sequência.
//public, private, protected,internal, protected internal, private protected.
{//obj. no nível abaixo (dentro da classe).
    //Acessível em qualquer lugar:
    //()parâmetro com array de strings - conj. de palavras ordenadas.
    //public static void Main(string[] args)//Método Main - Ponto/Código de Entrada. static = pertencimento (estático), faz o que a Classe HelloWorld comanda e funciona apenas dentro dessa classe.//void = método vazio (sem argumento), não retorna nenhum valor. Precisa ser executada. 
    static void Main()
    {
        //Inserir caracteres especiais/Configura o console para apresentar UTF-8:
        Console.OutputEncoding = Encoding.UTF8;
        
        //Solicitar o nome do usuário:
        Console.WriteLine ("Olá! Qual é o seu nome? ");
        string nome = Console.ReadLine(); //Lê a linha. string = atributo.
        //Console = é uma classe. Write Line(escreve uma linha).//Imprime letras e números.
        
        //Imprimir no terminal
        Console.WriteLine($"Olá, {nome}! Você é especial.");
    }
    //Acessível somente dentro da minha class HelloWorld:
    //private int PropriedadePrivada {get; set;}
}

using System;
using System.Text;

class Programa 
{
    static void Main()
    {
        //Usar UTF-8 no Console:
        Console.OutputEncoding = Encoding.UTF8;
        
        //Solicitar ao usuário o seu nome:
        Console.Write("Por favor, insira o seu nome: ");
        string nome = Console.ReadLine();
        
        //Solicitar ao usuário a data de nascimento:
        Console.Write("Agora, insira a sua data de nascimento (DD/MM/AAAA): ");
        string dataNascInput = Console.ReadLine();//dado de entrada.
        
        //Converter a string data_nasc para DataType (DateTime):
        DateTime dataNasc;
        if (DateTime.TryParseExact(dataNascInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNasc))//condição - tenta passar exatamente a data inserida para o formato desejado, se não cumprir a condição retorna valor nulo. Out = saída.
        {
            //Calcular a idade do usuário:
            int idade = CalcularIdade(dataNasc);
            
            //Responder o usuário no console:
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
        }
        else //Caso o usuário escreva errado.
        {
            Console.WriteLine("Insira uma data de nascimento válida (DD/MM/AAA).");
        }
        
        static int CalcularIdade(DateTime dataNasc)
        {
            //DateTime de hoje:
            DateTime hoje = DateTime.Today;
            
            //Calcular a idade:
            int idade = hoje.Year - dataNasc.Year;
            
            //Ajustar a idade caso não tenha completado aniversário:
            if(dataNasc.Date > hoje.AddYears(-idade)) idade--;
            //idade-- = se for verdadeiro:
            return idade;
        }
        
    }
}