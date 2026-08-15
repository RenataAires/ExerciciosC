Console.WriteLine("Adivinhe qual é o número secreto entre 1 e 100!");

int numeroSecreto = Random.Shared.Next(1, 101);

int tentativas = 0;

Console.WriteLine("------------------------------------");
Console.WriteLine("Digite um número entre 1 e 100:");

while (true)
{
    if (!int.TryParse(Console.ReadLine(), out int palpite))
    {
        Console.WriteLine("Valor inválido. Digite um número inteiro entre 1 e 100.");
        continue;
    }

    tentativas++;

    if (palpite < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior! Tente novamente:");
    }
    else if (palpite > numeroSecreto)
    {
        Console.WriteLine("O número secreto é menor! Tente novamente:");
    }
    else
    {
        Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
        break;
    }
}
