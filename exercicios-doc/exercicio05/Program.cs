namespace Exercicio05
{
    class Program 
    {
        public static void Main( string[] args )
        {
            // for(int a = 1; a <= 10; a++)
            // {
            //     for(int b = 1; b <= 10; b++)
            //     {
            //         Console.WriteLine($"{a} X {b} = {a*b} ");
            //     }
            //     Console.WriteLine();
            // }

            bool continuar = true;
            int numero;
            string resultado;
            
            while(continuar)
            {
                Console.Write($"Digite um numero pra saber a sua tabuada: ");
                numero = Int32.Parse(Console.ReadLine());
                
                Thread.Sleep(1000);

                for(int i = 1; i <= 10; i++)
                {
                    Console.Write($"{numero} X {i} = {numero * i} ");
                    Console.WriteLine();
                }
                Thread.Sleep(1000);
                Console.Write($"Gostaria de saber a tabuada de outro número? [S/N] ");
                resultado = Console.ReadLine();

                if(resultado == "S") continuar = true;
                else continuar = false;
            }
        }
    }
}