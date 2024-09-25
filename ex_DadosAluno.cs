using System;

class Program
{
    static void Main(string[] args)
    {
        //Declaração de uma variável;
        //tipo nomeVariavel = valor;
        int idadeAluno = 12;
        string nome = "Joaquim";
        bool matriculado = true;
        char generoAluno = "M";
        double alturaAluno = 1.23;
        Console.WriteLine(idadeAluno);
        idadeAluno = 13;
        Console.WriteLine(idadeAluno);

        //Constante:
        const int idadeAluno = 14;
        Console.WriteLine("Nome do aluno: " + nome);
        Console.WriteLine("Idade do aluno: " + idade);

        //Declarar múltiplas variáveis:
        int x = 5, y = 6, z = 33;
        Console.WriteLine (x + y + z);
        int a, b, c;
        a = b = c = 50;
        Console.WriteLine(a + b - c);

        //Regras de identifier:
        /*Não pode conter letras, dígitos e underscore (_)
        deve começar com letra ou underscore
        começa com letra minúscula e Camel case
        case-sensitive
        minhaVar != minhavar
        reservadas (C#, int, double, string)*/

        float f1 = 35e3F;
        Console.WriteLine(f1);

        //Casting (Conversão de tipos)
        int meuInt = 9;
        double meuDouble = meuInt;

        Console.WriteLine(meuInt);
        Console.WriteLine(meuDouble);

        double myDouble = 9.78;
        int myInt = (int) myDouble;

        Console.WriteLine(myDouble);
        Console.WriteLine(myInt);

        //Método de conversão
        ind idadeFuncionario = 34;
        double alturaFuncionario = 1.76;
        bool cltRegistro = true;

        Console.WriteLine(Convert.ToString(idadeFuncionario));
        Console.WriteLine(Convert.ToDouble(idadeFuncionario));
        Console.WriteLine(Convert.ToInt32(idadeFuncionario));
        Console.WriteLine(Convert.ToString(cltResgistro));
    }
}

/*1. Calculadora de IMC: Solicite ao usuário seu peso e altura, e retorne o seu IMC.
(IMC = peso/altura * 2) [Console.ReadLine]

2. Informe ao usuário sua condição (sobrepeso, normal, etc...)
- Baixo peso < 18.5;
- Peso normal < 24.9;
- Sobrepeso < 29.9;
- Obesidade grau 1 < 34.9;
- Obesidade grau 2 < 39.9
- Obesidade grau 3 (mórbida) > 39.9
*/

using System;

namespace CalculadoraIMC
{
    class Programa
    {
        static void Main(string[] args)
        {
            //Solicitar ao usuário seu peso:
            Console.WriteLine("Digite o seu peso (em kg): ");
            double peso = ConvertToDouble(Console.ReadLine());

            //Solicitar ao usuário a altura:
            Console.WriteLine("Digite a sua altura (em m): ");
            double altura = ConvertToDouble(Console.ReadLine());

            //Calcular o IMC:
            double imc = peso/(altura * altura);
            
            //Exibir o IMC:
            Console.WriteLine($"\nSeu IMC é: {imc:F2}");
            
            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso ideal");
            } else if (imc >= 18.5 && imc < 24.9) {
                Console.WriteLine("Condição: Peso Normal");
            } else if (imc >= 25 && imc < 29.9) {
                Console.WriteLine("Condição: Sobrepeso");
            } else if (imc >= 30 && imc < 39.9) {
                Console.WriteLine("Condição: Obesidade grau 1");
            } else if (imc >= 35 && imc < 39.9) {
                Console.WriteLine("Condição: Obesidade grau 2");
            } else {
                Console.WriteLine("Conidção: Obesidade grau 3: Obesidade grau 3");
            }
        }
    }
}
