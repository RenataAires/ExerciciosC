Console.WriteLine("Digite 10 números e eu te devolvo na ordem inversa!");

Console.WriteLine("------------------------------------");
Console.WriteLine("Digite os números:");

int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    if (!int.TryParse(Console.ReadLine(), out numeros[i]))
    {
        Console.WriteLine("Valor inválido. Digite um número inteiro.");
        i--; // Repetir a leitura para esta posição
        continue;
    }
}

Console.WriteLine("Os números na ordem inversa são: ");
for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.Write($"{numeros[i]} ");
}
Console.WriteLine();