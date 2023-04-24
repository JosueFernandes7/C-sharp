

namespace Triangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double perimetro()
        {
            return (this.A + this.B + this.C) / 2.0;
        }
        public double area()
        {
            return Math.Sqrt(this.perimetro() * (this.perimetro() - this.A) * (this.perimetro() - this.B) * (this.perimetro() - this.C));
        }
    }
}
