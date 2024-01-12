using System;

class Program
{
    static void Main()
    {
        int contador_repeticao = 0;

        while (contador_repeticao < 10)
        {
            Console.WriteLine("Escreva seu nome:");
            string Nome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade:");
            int Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva seu Peso:");
            float Peso = Convert.ToSingle(Console.ReadLine());

            if (Nome == "Mateus")
            {
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Idade: " + Idade);
                Console.WriteLine("Logado: " + Peso);
                ++contador_repeticao;
                continue;
            }
            else
            {
                Console.WriteLine("Erro ao Logar, você vai receber um DDOS");
            }
        }
    }
}
