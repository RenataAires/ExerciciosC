Console.WriteLine("----Vamos somar os números pares de 1 a 100----");

int soma = 0;
for (int i = 1; i <= 100; i++)
{
    if(i % 2 == 0)
    {
        soma += i;
    }
}

Console.WriteLine($"A soma dos números pares de 1 a 100 é: {soma}");
