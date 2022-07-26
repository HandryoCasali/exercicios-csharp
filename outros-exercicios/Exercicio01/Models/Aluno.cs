namespace Exercicio01.Models
{
    public class Aluno
    {
        public string Nome { get; set; }

        private double _media;
        public double Media
        {
            get
            {
                return _media;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Valor negativo para média");
                else
                    _media = value;
            }
        }

        
    }
}