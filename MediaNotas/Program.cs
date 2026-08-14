Console.WriteLine("Qual é a média de notas que você deseja calcular?");

double soma = 0;
int quantidade = 0;

for (int i = 1; i <= 8; i++)
{
    Console.Write($"Digite a {i}ª nota: ");
    if (!double.TryParse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture, out double notaAtual))
    {
        Console.WriteLine("Valor inválido. Digite um número válido para a nota.");
        i--; // Repetir a leitura para esta posição
        continue;
    }

    soma += notaAtual;
    quantidade++;
}

Console.WriteLine("\n------------------------------------");
if (quantidade > 0)
{
    double media = soma / quantidade;
    Console.WriteLine($"A média das notas digitadas é: {media:F2}");
}
else
{
    Console.WriteLine("Nenhuma nota válida foi digitada.");
}