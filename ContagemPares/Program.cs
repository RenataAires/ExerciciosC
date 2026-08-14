Console.WriteLine("Contador de números pares");

int contadorPares = 0;
for (int i = 1; i <=20 ; i++)
{
    Console.Write($"Digite o {i}º número: ");

    string entrada = Console.ReadLine() ?? "";

    if(!int.TryParse(entrada, out int numero))
    {
        Console.WriteLine("Valor inválido. Digite um número inteiro.");
        i--; // Repetir a leitura para esta posição
        continue;
    }   

    if( numero % 2 == 0)
    {
        contadorPares++;
    }
}
Console.WriteLine($"Você digitou 20 números e {contadorPares} são pares.");