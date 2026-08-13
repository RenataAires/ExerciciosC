Console.WriteLine("----Calculadora Simples----");

Console.Write("Digite o primeiro número: ");
var primeiroNumero = Console.ReadLine();
Console.Write("Digite o segundo número: ");
var segundoNumero = Console.ReadLine();

if(!double.TryParse(primeiroNumero, out double primeiroDouble))
{
    Console.WriteLine($"O valor {primeiroNumero} digitado não é um número válido");
    Console.ReadKey(true);
    return;
}

if(!double.TryParse(segundoNumero, out double segundoDouble))
{
    Console.WriteLine($"O valor {segundoNumero} digitado não é um número válido");
    Console.ReadKey(true);
    return;
}

var soma = primeiroDouble + segundoDouble;
var subtracao = primeiroDouble - segundoDouble;
var multiplicacao = primeiroDouble * segundoDouble;
var divisao = segundoDouble != 0 ? primeiroDouble / segundoDouble : double.NaN;

Console.WriteLine($"A soma dos números é: {soma}");
Console.WriteLine($"A subtração dos números é: {subtracao}");
Console.WriteLine($"A multiplicação dos números é: {multiplicacao}");
if (double.IsNaN(divisao))
{
    Console.WriteLine("Não é possível dividir por zero.");
}
else
{
    Console.WriteLine($"A divisão dos números é: {divisao}");
}