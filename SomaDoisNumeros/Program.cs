using System.Reflection;
using System.Runtime.InteropServices;

Console.WriteLine("-----Olá, usuário! Vamos brincar de somar?-----");

Console.WriteLine("Digite o primeiro número");
var num1 = Console.ReadLine();
Console.WriteLine("Digite o segundo número");
var num2 = Console.ReadLine();

if(!int.TryParse(num1, out int valor1))
{
    Console.WriteLine($"O valor {num1} digitado não é um número inteiro");
    Console.ReadKey(true);
    return;
}
if(!int.TryParse(num2, out int valor2))
{
    Console.WriteLine($"O valor {num2} digitado não é um número inteiro");
    Console.ReadKey(true);
    return;
}

var soma = valor1 + valor2;

Console.WriteLine($"A soma dos números: {valor1} + {valor2} + é: {soma}");