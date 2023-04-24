using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public override bool Equals(object? obj)
        {
            if(obj is Produto)
            {
                Produto newObj = (Produto)obj;
                return newObj.Preco == Preco && newObj.Quantidade == Quantidade && newObj.Nome == Nome;
            }
            return false;
        }
    }
}