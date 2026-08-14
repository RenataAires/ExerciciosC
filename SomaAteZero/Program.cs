Console.WriteLine("Soma de números - Digite zero para encerrar o programa");    

int soma = 0;
int numero;

do
{
    Console.Write("Digite um número: ");
    string entrada = Console.ReadLine() ?? "";

    if (!int.TryParse(entrada, out numero))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        continue; // Volta para o início do loop para solicitar a entrada novamente
    }
    
        soma += numero;

} while (numero != 0); 

Console.WriteLine($"\nPrograma encerrado.A soma dos números digitados é: {soma}");