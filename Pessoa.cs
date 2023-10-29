using System.Globalization;

namespace Objetos
{

    public class Pessoa
    {
        public string? nome;
        public DateTime nascimento;

        public Pessoa()
        {

        }
        public string calcularExpectativaDeVida()
        {
            int idadeAtual = DateTime.Now.Year - nascimento.Year;
            DateTime falecimento = this.nascimento.AddYears(100);
            int expectativa = falecimento.Year - DateTime.Now.Year;

            if (DateTime.Now.Month < nascimento.Month)
            {
                idadeAtual--;
                expectativa++;
            }

            if (DateTime.Now.Month == nascimento.Month)
            {
                if (DateTime.Now.Day < nascimento.Day)
                {
                    idadeAtual--;
                    expectativa++;
                }
            }
            return $"Sua idade é {idadeAtual}, viverá mais {expectativa} anos até a data {falecimento.ToString("dd/MM/yyyy")} em um(a) {falecimento.ToString("dddd", new CultureInfo("pt-BR"))}";
        }
    }
}