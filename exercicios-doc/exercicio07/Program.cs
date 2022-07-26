namespace Exercicio07
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] listaDeNumeros = new int[5];
            
            for (var i = 0; i < listaDeNumeros.Length; i++)
            {
                Console.Write($"Digite o {i+1}º número de {listaDeNumeros.Length}º numero(s): ");
                listaDeNumeros[i] = int.Parse(Console.ReadLine());
            }
            for (var i = listaDeNumeros.Length-1; i >= 0; i--)
            {
                Console.WriteLine($"{listaDeNumeros[i]}");
            }
        }
    }
}