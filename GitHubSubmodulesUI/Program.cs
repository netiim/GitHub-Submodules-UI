
using Framework.Services;

PessoaService p = new PessoaService();
Console.WriteLine(p.ExibirDetalhes(new Framework.Domain.Pessoa()
{
    Nome = "Paulo",
    Idade = 15,
    Altura = 1.65
})  );  