Console.WriteLine("Vamos calcular a área de um retângulo!");
Console.Write("Digite a base: ");
var baseRetangulo = Console.ReadLine();
Console.Write("Digite a altura: ");
var alturaRetangulo = Console.ReadLine();

if(!double.TryParse(baseRetangulo, out double baseDouble))
{
    Console.WriteLine($"O valor {baseRetangulo} digitado não é um número válido");
    Console.ReadKey(true);
    return;
}

if(!double.TryParse(alturaRetangulo, out double alturaDouble))
{
    Console.WriteLine($"O valor {alturaRetangulo} digitado não é um número válido");
    Console.ReadKey(true);
    return;
}

var area = baseDouble * alturaDouble;
Console.WriteLine($"A área do retângulo é {area}");