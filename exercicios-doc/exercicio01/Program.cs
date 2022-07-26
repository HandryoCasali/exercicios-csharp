namespace Exercicio01
{
    public class Program
    {
        public static void Main (string[] args)
        {
            Pessoa pessoa = new Pessoa();


            Console.Write($"Olá!!! Digite seu nome: ");
            pessoa.nome =  Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine($"Olá {pessoa.nome}!!!");

            
            pessoa.ValidarDataNasc();
            pessoa.ValidarVoto();
            Console.Read();
        }

        class Pessoa
        {
            public string ?nome;
            public int dataNasc {get; set;} 
            public int idade;

            public void ValidarDataNasc()
            {
                // Variáveis de apoio
                string ?entradaDataNasc;    
                bool resultConversao;
                int dataNascConvertida;  

                Thread.Sleep(1000);
                Console.Write($"{this.nome}, digite o ano do seu nascimento: ");
                entradaDataNasc = Console.ReadLine();

                resultConversao = Int32.TryParse(entradaDataNasc, out dataNascConvertida);

                while(resultConversao == false || dataNascConvertida < 0 || DateTime.Today.Year - dataNascConvertida < 0 || DateTime.Today.Year - dataNascConvertida > 150)
                {
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"Digite um ano válido: ");
                    Console.ResetColor();

                    entradaDataNasc = Console.ReadLine();
                    resultConversao = Int32.TryParse(entradaDataNasc, out dataNascConvertida); 
                }
                
            this.dataNasc = dataNascConvertida;
            }

            public void ValidarIdade()
            {   
                this.idade = DateTime.Today.Year - this.dataNasc;
                Thread.Sleep(1000);
                Console.WriteLine($"Você tem {idade} ano(s).");

                return;
            }

            public void ValidarVoto()
            {
                this.ValidarIdade();
                if(idade >= 18 && idade <= 70 )
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Você poderá votar esse ano, e seu voto é OBRIGATÓRIO!!!");
                    return;
                }
                else if(idade >= 16 || idade > 70)
                {   
                    Thread.Sleep(1000);
                    Console.WriteLine($"Você poderá votar esse ano, e seu voto é FACULTATIVO!!!");
                    return;
                }
                else 
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Você ainda não atingiu a idade mínima para votar!");
                    return;
                }
            }   
        }

        
        
    }
}