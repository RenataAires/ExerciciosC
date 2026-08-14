Console.WriteLine("----Bem-vindo(a) ao Contador de Caracteres----");
Console.WriteLine("Digite um nome para contar os caracteres:");

string? nome = Console.ReadLine();
nome ??= string.Empty;

int quantidadeCaracteres = nome.Length;
Console.WriteLine($"O nome '{nome}' possui {quantidadeCaracteres} caracteres.");

