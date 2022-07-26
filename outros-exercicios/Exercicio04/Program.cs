// Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

using System;

namespace Exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine($"Digite o salário pra saber o novo salário reajustado: ");
            double salario = double.Parse(Console.ReadLine());
            double salarioReajustado = 0;
            int porcentagem = 0;
            if (salario < 0)
            {
                Console.WriteLine($"Salário negativo??");
            }
            else if (salario <= 300)
            {
                porcentagem = 50;
            }
            else
            {
                porcentagem = 30;
            }

            salarioReajustado = salario + (salario * porcentagem / 100);
            Console.WriteLine($"Salário antigo era R${salario:.00}");
            Console.WriteLine($"Com {porcentagem}% de reajuste passará a ser R${salarioReajustado:.00}");
            
        }
    }
}