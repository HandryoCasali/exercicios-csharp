// Faça um algoritmo que leia a altura e a matricula de dez aluno. Mostre a matricula do aluno mais alto e do aluno mais baixo.

using System;
using Exercicio05.Models;
namespace Exercicio05
{
    public class Program
    {
        public static void Main(string[] args)
        {;
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno(){Nome = "Handryo", Altura = 1.7f},
                new Aluno(){Nome = "Jhonatan", Altura = 1.2f},
                new Aluno(){Nome = "Placido", Altura = 1.5f},
                new Aluno(){Nome = "Rosangela", Altura = 1.7f}
            };
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
                        AlunoMaisAltoEMaisBaixo(alunos);

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
                Console.WriteLine($"(3) - Mostrar aluno mais alto e mais baixo");
                Console.WriteLine($"(0) - Sair do sistema\n");
                Console.Write($"Digite sua opção: ");
            }

            static Aluno CadastrarAluno()
            {
                var aluno = new Aluno();

                Console.Write($"Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.Write($"Digite a altura do aluno: ");
                aluno.Altura = float.Parse(Console.ReadLine());

                Console.WriteLine($"Aluno {aluno.Nome} cadastrado com sucesso!");

                return aluno;
            }

            static void ListarAlunos(List<Aluno> alunos)
            {
                foreach (var aluno in alunos)
                {
                    if (!string.IsNullOrEmpty(aluno.Nome))
                    {
                        Console.WriteLine($"Aluno: {aluno.Nome} \t Altura: {aluno.Altura}");
                    }
                }
            }

            static void AlunoMaisAltoEMaisBaixo(List<Aluno> alunos)
            {
                Aluno alunoMaisAlto = alunos.Max();
                Aluno alunoMaisBaixo = alunos.Min();
                Console.WriteLine($"{alunoMaisAlto.Nome} é o aluno mais alto da turma com {alunoMaisAlto.Altura}m.");
                Console.WriteLine($"{alunoMaisBaixo.Nome} é o aluno mais baixo da turma com {alunoMaisBaixo.Altura}m.");
            }
        }


    }
}