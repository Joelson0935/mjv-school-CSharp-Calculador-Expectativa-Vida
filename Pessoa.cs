namespace Objetos
{

    public class Pessoa
    {
        public string? nome;
        public DateTime nascimento;

        public Pessoa()
        {

        }
        public DateTime adicionaCemAnos(DateTime nascimento)
        {
            DateTime resultado = nascimento.AddYears(100);
            return resultado;
        }
    }

}