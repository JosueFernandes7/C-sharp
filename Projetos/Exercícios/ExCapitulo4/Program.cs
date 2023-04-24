
namespace ExCapitulo4
{
class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            


            Console.WriteLine("Entre a largura e altura do retângulo");
            retangulo.largura = double.Parse(Console.ReadLine());
            retangulo.comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA = {0:F2}",retangulo.area());
            Console.WriteLine("PERÍMETRO = {0:F2}",retangulo.perimetro());
            Console.WriteLine("DIAGONAL = {0:F2}", retangulo.diagonal());
        }
    }
}