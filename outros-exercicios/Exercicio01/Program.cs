//  Elabore um algoritmo que calcule a idade média de 5 alunos.

using System;
using Exercicio01.Models;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            Console.WriteLine("Bem vindo ao sistema!\n");
            
            Thread.Sleep(1000);
            string opcao;

            do
            {
                MostrarMenuOpcao();

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        var aluno = CadastrarAluno();
                        alunos.Add(aluno);

                        break;
                    case "2":
                        Console.Clear();
                        ListarAlunos(alunos);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Media geral dos alunos: {MediaGeralALunos(alunos)}");
                        
                        break;
                    case "0":
                        Console.WriteLine($"Saindo do sistema...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opcao inválida, digite novamente!\n");
                        break;
                }

            } while (opcao != "0");






            static void MostrarMenuOpcao()
            {
                Console.WriteLine($"(1) - Cadastrar novo aluno");
                Console.WriteLine($"(2) - Listar alunos cadastrados");
                Console.WriteLine($"(3) - Mostrar média geral");
                Console.WriteLine($"(0) - Sair do sistema\n");
                Console.Write($"Digite sua opção: ");
            }

            static Aluno CadastrarAluno()
            {
                var aluno = new Aluno();

                Console.Write($"Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.Write($"Digite a média do aluno: ");
                aluno.Media = double.Parse(Console.ReadLine());

                Console.WriteLine($"Aluno {aluno.Nome} cadastrado com sucesso!");

                return aluno;
            }

            static void ListarAlunos(List<Aluno> alunos)
            {
                foreach (var aluno in alunos)
                {
                    if (!string.IsNullOrEmpty(aluno.Nome))
                    {
                        Console.WriteLine($"Aluno: {aluno.Nome} \t Media: {aluno.Media}");
                    }
                }
            }

            static double MediaGeralALunos(List<Aluno> alunos)
            {
                double mediaSoma = 0;
                int totalALunos = 0;
                foreach (var aluno in alunos)
                {
                    if (!String.IsNullOrEmpty(aluno.Nome))
                    {
                        mediaSoma += aluno.Media;
                        totalALunos++;
                    }
                }
                return mediaSoma / totalALunos;
            }
        }
    }
}