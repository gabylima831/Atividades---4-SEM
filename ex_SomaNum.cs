//Soma de 2 números:
using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int soma = num1 + num2;
        Console.WriteLine("A soma dos números é: " + soma);
    }

}

//Soma de 2 números usando condição if:
class Program 
{
    static void Main()
    {
        Console.WriteLine("Digite um  número:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}

//Soma de 2 números usando laço for:
class Program 
{
    static void Main()
    {
        Console.WriteLine("Digite um  número para ver a tabuada:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * 1}");
        }
    }

}

//EXERCÍCIOS
//Escreva um programa que exiba os números de 1 a 10 utilizando um loop for.

using System;

class Program 
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

//Escreva um programa que solicite ao usuário para inserir 
//três números e, em seguida, calcule e exiba a média deles.

using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double num = Convert.ToDouble32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        double num3 = Convert.ToDouble32(Console.ReadLine());

        double media = (num1 + num2 + num3)/3;
        Console.WriteLine("A média dos números é: " + media);

        byte idade = 33;

        short temperatura = 30;
    }
}

//*NOTAS
//Double = ponto flutuante com alta precisão e intervalos grandes;
//Float = ponto flutuante quando a memória é uma preocupação;
//Decimal = cálculos de alta precisao (128 bits) - Stock Market;
//Int, Long, Short, Byte = números inteiros de diferentes tamanhos;

//PROGRAMA 1
/*Você vai criar um programa que calcula o salário de um funcionário com base nas horas trabalhadas,
na taxa de pagamento por hora e no valor das comissões. O programa deve usar diferentes tipos de dados 
para armazenar as informações e realizar as operações necessárias.

REQUISITOS:
1. Solicite ao usuário para inserir o nome do funcionário (string);
2. Solicite ao usuário para inserir as horas trabalhadas na semana (int);
3. Solicite ao usuário para inserir a taxa de pagamento por hora (double);
4. Solicite ao usuário para inserir o valor das comissões recebidas na semana (decimal);
5. Calcule o salário bruto (horas trabalhadas multiplicadas pela taxa de pagamento) e adicione as
comissões;
6. Exiba o nome do funcionário e o salário total (decimal) no final.*/

using System;

class CalculadoraSalario
{
    static void Main()
    {
        //Solicitar o nome do funcionário:
        Console.WriteLine("Digite o nome do funcionário: ");
        string nomeFuncionario = Console.ReadLine();

        //Solicitar as horas trabalhadas:
        Console.WriteLine("Digite as horas trabalhadas por esse funcionário: ");
        int horasTrabalhadas = ConvertToInt32(Console.ReadLine());

        //Solicitar ao usuário para inserir a taxa de pagamento por hora:
        Console.WriteLine("Digite a taxa de pagamento por hora: ");
        double taxaPorHora = Convert.ToDouble(Console.ReadLine());

        //Solicitar para inserir valor das comissões recebidas na semana:
        Console.WriteLine("Insira o valor das comissões recebidas na semana: ");
        decimal comissoes = Convert.ToDecimal(Console.ReadLine());

        //Calcule o salário bruto:
        decimal salarioBruto = (decimal)(horasTrabalhadas * taxaPorHora);

        //Calcular o salário com comissão:
        decimal salarioTotal = salarioBruto + comissoes;

        //Exibir o resultado final:
        Console.WriteLine($"\nO funcionário {nomeFuncionario} tem um salário total de R$ {salarioTotal}");

        string valorString = null;
        string valorString = '123';
        int valorInt = ConvertToInt32(valorString); //computar no runtime.
        int valorInt = int.Parse(valorString);
    }
}

/*PROGRAMA 2
- Crie um programa em C# que peça ao usuário para inserir um caractere e exiba, em seguida, 
esse caractere de quatro encoding diferentes.

1. Literal de caractere;
2. Unicode;
3. Hexadecimal;
4. Inteiro para char;*/

using System;

class RepresentacaoDeCaracteres
{
    static void Main()
    {
        //Solicitar ao usuário inserir um caractere:
        Console.WriteLine("Digite um caractere: ");
        char caractere = Console.ReadKey().KeyChar;
        Console.WriteLine;

        //Converter o caractere conforme o enunciado:
        string unicodeRepresentacao = $"\\u{(int)caractere:x4}";

        string hexadecimalRepresentacao = $"\\x{(int)caractere:x4}";

        int intRepresentacao = (int)caractere;

        //Exibir as representações:
        Console.WriteLine($"Caractere Literal: '{caractere}'");
        Console.WriteLine($"Representação Unicode: '{unicodeRepresentacao}'");
        Console.WriteLine($"Representação Hexadecimal: '{hexadecimalRepresentacao}'");
        Console.WriteLine($"Representação como inteiro: '{intRepresentacao}'");
        int horasTrabalhadas = ConvertToInt32(Console.ReadLine());
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}