Console.WriteLine("Bem-vindo ao Caixa Eletrônico!");
Console.WriteLine("------------------------------------");


int[] notasDisponiveis = { 100, 50, 20, 10, 5, 2, };
Console.Write("Digite o valor que deseja sacar (em reais): ");

if (!int.TryParse(Console.ReadLine(), out int valorSaque))
{
    Console.WriteLine("Valor inválido. Digite apenas números inteiros.");
    return;
}

if(valorSaque <= 0 || valorSaque == 1 || valorSaque == 3)
{
    Console.WriteLine("Valor inválido. O valor deve ser maior que zero e não pode ser 1 ou 3.");
    return;
}

Console.WriteLine("\nNotas disponíveis para saque:");

foreach (int nota in notasDisponiveis)
{
    int quantidadeNotas = valorSaque / nota;
    if (quantidadeNotas > 0)
    {
        Console.WriteLine($"R$ {nota}: {quantidadeNotas} nota(s)");
        valorSaque %= nota;
    }
}

if (valorSaque > 0)
{
    Console.WriteLine($"Não é possível sacar o valor restante de R$ {valorSaque} com as notas disponíveis.");
}
