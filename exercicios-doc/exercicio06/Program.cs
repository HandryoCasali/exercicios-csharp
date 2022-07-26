namespace Exercicio06
{
    class Program 
    {
        public static void Main(string[] args)
        {   
            string[] listaDeNomes = new string[5];
            bool achou = false;

            for( int i = 0; i < listaDeNomes.Length; i++)
            {
                Console.Write($"Digite o {i+1}º nome de {listaDeNomes.Length}º nome(s): ");
                listaDeNomes[i] = Console.ReadLine();
            }
            Console.Write($"Digite mais um nome pra efetuar a busca: ");
            string ?nomeBusca = Console.ReadLine();
            
            if(listaDeNomes.Contains(nomeBusca))
            {
                achou = true;
            }
            
            if(achou)
            {
                Console.WriteLine($"Achei o nome na lista.");
            }
            else
            {
                Console.WriteLine($"Não achei o nome na lista.");
                
            }  
            

        }
    }
}