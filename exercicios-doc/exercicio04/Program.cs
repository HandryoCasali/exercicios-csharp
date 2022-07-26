namespace Exercicio04
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] valores = new int[5];

            bool result;

            for(int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o {i+1}º valor de {valores.Length}º valores: ");
                result = Int32.TryParse(Console.ReadLine(), out valores[i]);    
            }
            int menorValor = valores[0];
            int maiorValor = valores[0];
            for(int i = 0; i < valores.Length; i++)
            {
                if(valores[i] < menorValor)
                {
                    menorValor = valores[i];
                }
                else if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Menor Valor : {menorValor}");
            Console.WriteLine($"Maior Valor : {maiorValor}");
            Console.ResetColor();

                // Console.WriteLine($"Digite o {i+1}º valor de {valores.Length}º valores");
        }
    }
}