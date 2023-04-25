
using System.Globalization;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            ContaBancaria conta = new ContaBancaria(numeroConta, titularConta);
            bool depositoInicial = Console.ReadLine().Contains('s');
            if(depositoInicial)
            {
                Console.Write("Entre o valor de depósito inicial: ");
                conta.deposito(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
        }

    }

}