/*Imprima no terminal o doguinho:
            __
      (___()'`;
      /,    /`
      \\"--\\
*/

using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("      __ ");
        Console.WriteLine("(___()'`;");
        Console.WriteLine("/,    /`");
        Console.WriteLine("\\\\\"--\\\\");
    }

}

/*2. Armazene o desenho do cachorro em uma variável "Doguinho" e depois imprima ela no console;*/

using System;

class Program 
{
    static void Main(string[] args)
    {
        string doguinho = @"
            __
      (___()'`;
      /,    /`
      \\""--\\";

        Console.WriteLine(doguinho);
    }
}

/*3.Agora, armazene o doguito em uma classe e imprima em outra;*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //Criar uma instância para a classe Dog:
        Dog dog = new Dog();
        //Chamar o método para obter o desenho:
        string dogDrawing = dog.GetDogDrawing();

        Console.WriteLine(dogDrawing);

        string doguinho = @"

            __
      (___()'`;
      /,    /`
      \\""--\\";
    }
}

class Dog
{
    public string GetDogDrawing()
    {
        return @"
            __
      (___()'`;
      /,    /`
      \\""--\\";
    }
}
*/

/*4.Crie uma aplicação em C# que armazena e imprime diferentes desenhos ASCII (desenhos em texto)
usando classes separadas. Você deve criar uma classe para cada desenho e uma classe principal
que coordena a impressão de todos os desenhos.
-> Crie uma classe Dog que armazena o desenho de um cachorro.
-> Crie uma classe Cat que armazena o desenho de um gato.
-> Crie uma classe Fish que armazena o desenho de um peixe.
Crie um menu de usuário, para escolher qual desenho deseja visualizar.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while(!running)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção de desenho:");
            Console.WriteLine("1 - Cachorro");
            Console.WriteLine("2 - Gato");
            Console.WriteLine("3 - Peixe");
            Console.WriteLine("0 - Encerrar o programa");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite sua escolha:");

            string escolhaUsuario = Console.ReadLine();

            switch (escolhaUsuario) {
                case "1":
                    Dog dog = new Dog();
                    Console.WriteLine(dog.GetDogDrawing());
                    break;
                case "2":
                    Cat cat = new Cat();
                    Console.WriteLine(cat.GetCatDrawing());
                    break;
                case "3":
                    Fish fish = new Fish();
                    Console.WriteLine(fish.GetFishDrawing());
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Saindo do sistema... Até breve!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            
            if (running)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial.");
                Console.ReadKey();
            }
            
        }
    }
}

/*5. Crie um Menu Interativo com Desenhos ASCII e Funções Extras.
a) Requisitos funcionais: Desenvolver uma aplicação de controle em C# que permita ao usuário
escolher entre vários desenhos ASCII, exibir uma lista de todos os desenhos disponíveis, e adicionar novos 
desenhos dinamicamente.

I. Criar classes para cada desenho (no mínimo 4);
II. Cada classe deverá implementar uma interface 'IDrawing', que define o método 'string getDrawing();
III. Armazenar os desenhos em uma coleção dentro de uma lista ('List<Drawing>') para armazenar instâncias 
de cada classe.
IV. Inicializar a lista de instâncias de cada classe.
V. Criar um menu principal em loop;
VI. Trabalhar com validação de entrada;*/

using System;

interface IDrawing
{
    string GetDrawing();
    string Name { get; }
}

class Dog : IDrawing
{
    public string Name => "Cachorro";
    public string GetDrawing()
    {
        return @"
            __
      (___()'`;
      /,    /`
      \\""--\\";
    }
}

class Cat : IDrawing
{
    public string Name => "Gato";
    public string GetDrawing()
    {
        return @"
        
             /\_/\  (
            ( ^.^ ) _)
              \/  ""(""
            ( | | )
           (__d b__)";
    }
}


class Fish : IDrawing
{
    public string Name => "Peixe";
    public string GetDrawing()
    {
        return @"
        
            /`·.¸
          /¸...¸`:·
        ¸.·´  ¸   `·.¸.·´)
      : © ):´;      ¸  {
        `·.¸ `·  ¸.·´\`·¸)
          `\\´´\¸.·´";
    }
}

class Fish : IDrawing
{
    public string Name => "Peixe";
    public string GetDrawing()
    {
        return @"
        
           (
          `-`-.
         '( @ >
          _) (
         /    )
        /_,'  / 
          \  / 
       ===m""m===";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IDrawing> drawings = new List<IDrawing> { new Dog(), new Cat(), new Fish(), new Bird()};
        bool running = true;

         while(running)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção de desenho:");
            Console.WriteLine("1 - Cachorro");
            Console.WriteLine("2 - Gato");
            Console.WriteLine("3 - Peixe");
            Console.WriteLine("4 - Pássaro");
            Console.WriteLine("0 - Encerrar o programa");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite sua escolha:");

            string escolhaUsuario = Console.ReadLine();

            switch (escolhaUsuario) {
                case "1":
                    Dog dog = new Dog();
                    Console.WriteLine(dog.GetDogDrawing());
                    break;
                case "2":
                    Cat cat = new Cat();
                    Console.WriteLine(cat.GetCatDrawing());
                    break;
                case "3":
                    Fish fish = new Fish();
                    Console.WriteLine(fish.GetFishDrawing());
                    break;
                case "4":
                    Bird bird = new Bird();
                    Console.WriteLine(bird.GetBirdDrawing());
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Saindo do sistema... Até breve!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            
            if (running)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial.");
                Console.ReadKey();
            }
            
        }
    }
    static void MostraDesenho(List<IDrawing> drawings)
                    {
                        Console.WriteLine("Escolha um desenho para mostrar:");
                        for (int i = 0; i < drawings.Count; i++) {
                            Console.WriteLine($"{ i + 1} - { drawings[i].Name}");
                        }
                    }
}
