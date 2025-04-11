// See https://aka.ms/new-console-template for more information
int CalcularSaldo(int vitorias, int derrotas)
{
    return vitorias - derrotas;
}

string DeterminarNivel(int vitorias)
{
    return vitorias switch
    {
        < 10 => "Ferro",
        <= 20 => "Bronze",
        <= 50 => "Prata",
        <= 80 => "Ouro",
        <= 90 => "Diamante",
        <= 100 => "Lendário",
        _ => "Imortal"
    };
}

while (true)
{
    Console.Write("Digite o número de vitórias: ");
    var inputVitorias = Console.ReadLine();

    Console.Write("Digite o número de derrotas: ");
    var inputDerrotas = Console.ReadLine();

    if (!int.TryParse(inputVitorias, out int vitorias) || !int.TryParse(inputDerrotas, out int derrotas))
    {
        Console.WriteLine("Valores inválidos. Tente novamente.\n");
        continue;
    }

    int saldoVitorias = CalcularSaldo(vitorias, derrotas);
    string nivel = DeterminarNivel(vitorias);

    Console.WriteLine($"\nO Herói tem de saldo de **{saldoVitorias}** está no nível de **{nivel}**\n");

    Console.Write("Deseja testar outro jogador? (s/n): ");
    if (Console.ReadLine()?.ToLower() != "s")
        break;

    Console.WriteLine();
}
