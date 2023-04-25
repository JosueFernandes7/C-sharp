


namespace Banco
{
    class ContaBancaria
    {
        private int _numero;
        private string _titular;
        private double _saldo;

        public int Numero { get => _numero; set => _numero = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public string Titular { get => _titular; set => _titular = value; }

        public ContaBancaria(int numero,string titular)
        {
            _numero = numero;
            _titular = titular;
        }


        public void deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void saque(double quantia)
        {
            if (quantia >= Saldo)
            {
                Saldo -= quantia;
            }
        }

        public override string ToString()
        {
            return "Conta " +
                    Numero + ", " +
                    "Titular: " + Titular +
                    ", Saldo: $ " + Saldo;
   
        }
    }

}
