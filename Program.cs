using Objetos;

Pessoa pessoa = new Pessoa();
try
{
    Console.WriteLine("Escreva o seu nome e aperte ENTER");
    pessoa.nome = Console.ReadLine();
    Console.WriteLine("Escreva a data de seu nascimento, exemplo: dia/mês/ano e aperte ENTER");
    string? data = Console.ReadLine();
    pessoa.nascimento = DateTime.Parse(data);
    Console.WriteLine("Nome: " + pessoa.nome);
    Console.WriteLine("Data de Nascimento: " + pessoa.nascimento.ToString("dd/MM/yyyy"));
    Console.WriteLine(pessoa.calcularExpectativaDeVida());
}
catch (System.FormatException)
{
    Console.WriteLine("Data escrita no formato inválido, tente novamente.");
}