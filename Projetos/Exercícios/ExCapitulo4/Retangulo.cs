

namespace ExCapitulo4
{
    class Retangulo
    {
        public double largura;
        public double comprimento;
        public double area ()
        {
            return largura * comprimento;
        }
        public double perimetro()
        {
            return 2 * largura + 2 * comprimento;
        }
        public double diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(comprimento, 2));
        }
    }
}
