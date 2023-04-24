

namespace ExCapitulo4
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public string maior(Pessoa outraPessoa)
        {
            return outraPessoa.idade > this.idade ? outraPessoa.nome : (outraPessoa.idade == this.idade ? "Mesma Idade" : this.nome);
        }
    }
}
