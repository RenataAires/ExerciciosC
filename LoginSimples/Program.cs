Console.WriteLine("Bem-vindo ao sistema de login!");

Console.Write("Digite seu nome de usuário: ");
string usuario = Console.ReadLine() ?? "";

Console.Write("Digite sua senha: ");
string senha = Console.ReadLine() ?? "";

while (usuario != "admin" || senha != "1234")
{
    Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
    Console.Write("Digite seu nome de usuário: ");
    usuario = Console.ReadLine() ?? "";

    Console.Write("Digite sua senha: ");
    senha = Console.ReadLine() ?? "";
}

Console.WriteLine("Login bem-sucedido! Bem-vindo ao sistema.");