Console.WriteLine("-----Localizando o maior valor-----");

int maiorValor = int.MinValue;
int posicao = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}º valor:");
    if (!int.TryParse(Console.ReadLine(), out int numeroAtual))
    {
        Console.WriteLine("Valor inválido. Digite um número inteiro.");
        i--; // Repetir a leitura para esta posição
        continue;
    }

    if (numeroAtual > maiorValor)
    {
        maiorValor = numeroAtual;
        posicao = i;
    }
}

Console.WriteLine("\n------------------------------------");
Console.WriteLine($"O maior valor digitado foi: {maiorValor}");
Console.WriteLine($"Ele apareceu na {posicao}ª posição.");;