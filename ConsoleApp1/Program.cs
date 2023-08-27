using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num_1, num_2, soma = 0, escolha;

            Console.WriteLine("Digite o primeiro número:");
            num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um operação! ");
            Console.WriteLine("1 - Somar\t 2 - Subtrair\t 3 - Dividir\t 4 - Multiplicar");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                    case 1: Console.WriteLine($"A soma do número {num_1} + {num_2} = {Soma(num_1,num_2)}");
                    break;
                    case 2: Console.WriteLine($"A Subtração do número {num_1} - {num_2} = {Subtrair(num_1,num_2)}");
                    break;
                    case 3: Console.WriteLine($"A Divisão do número {num_1} / {num_2} = {Dividir(num_1,num_2)} ");
                    break;
                    case 4: Console.WriteLine($"A Multiplicação do número {num_1} * {num_2} = {Multiplicar(num_1, num_2)}");
                    break;

            }               


            Console.WriteLine();
        }

       public static int Soma(int numero, int numero1)
        {
            return numero + numero1;
        }

        public static int Subtrair(int numero, int numero1)
        {
            return numero - numero1;
        }
        public static int Dividir(int numero, int numero1)
        {
            switch (numero) {
                case 0: Console.WriteLine("Não pode ser divisivel por zero");
                break;
                }
            return numero / numero1;
        }
        public static int Multiplicar(int numero, int numero1)
        {
            return numero * numero1;
        }
     }

}

