Console.WriteLine("---------Verificador de Senha---------");

Console.WriteLine("Digite uma senha para verificar se ela é forte:");
string senha = Console.ReadLine() ?? "";

if (senha.Length >= 8)
{
    Console.WriteLine("Senha aprovada! Ela possui pelo menos 8 caracteres.");
}
else
{
    int faltam = 8 - senha.Length;
    Console.WriteLine("A senha é fraca.");
    Console.WriteLine($"Ela tem apenas {senha.Length} caracteres. Faltam {faltam} para atingir o mínimo.");
}