// Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.

using System;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] idades = new int[10]
            {
                18, 20, 4, 5, 6, 13, 17, 21, 22, 20
            };
            int qntMaiorDeIdade = 0;
            
            foreach(var idade in idades)
            {
                if(idade >= 18) qntMaiorDeIdade++;
            }

            Console.WriteLine($"{qntMaiorDeIdade} pessoas são maiores de idade");
            
        }
    }
}