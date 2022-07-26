namespace Exercicio05.Models
{
    public class Aluno : IComparable
    {
        public string Nome { get; set; }

        private float _altura;
        public float Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Valor negativo para altura");
                }
                
                _altura = value;
            }
        }

        public int CompareTo(object? obj)
        {
            var aluno = obj as Aluno;

            if(aluno == null)
            {
                return - 1;
            }

            if(Altura < aluno.Altura)
            {
                return -1;
            }

            if(Altura == aluno.Altura)
            {
                return 0;
            }

            return 1;

            // retornar negativo quando a instancia precede o obj
            // retornar 0 quando a instancia quando forem equivalentes;
            // retornar positivo quando a instancia for maior
        }
    }
}