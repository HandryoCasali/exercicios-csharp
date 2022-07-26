// Crie um algoritmo que verifique se um número informado é par ou impar

using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string parOuImpar = "impar";
            Console.Write($"Digite um número para saber se é par ou impar: ");

            if(int.TryParse(Console.ReadLine(), out int num))
            {
                if(num % 2 == 0)
                {
                    parOuImpar = "par";
                }
                Console.WriteLine($"O numero: {num} é {parOuImpar}");
            } 
        }
    }
}