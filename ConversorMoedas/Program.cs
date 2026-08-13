Console.WriteLine("Conversor de moedas");
Console.Write("Digite o valor em reais: ");
var valorReais = Console.ReadLine();

if(!double.TryParse(valorReais,  out double valorDouble))
{
    Console.WriteLine($"O valor {valorReais} digitado não é um número válido");
    Console.ReadKey(true);
    return;
}

var valorDolar = valorDouble / 5.21;
Console.WriteLine($"O valor em dólares é {valorDolar:F2}");

