Console.WriteLine("-----Olá! Me diga um número e eu te direi o antecessor e o sucessor-----");
var numero = Console.ReadLine();

if(!int.TryParse(numero, out int num))
{
    Console.WriteLine($"O valor {numero} digitado não é um número inteiro");
    Console.ReadKey(true);
    return;
}
var antecessor = num - 1;
var sucessor = num + 1;
Console.WriteLine($"O antecessor de {num} é {antecessor} e o sucessor é {sucessor}");
