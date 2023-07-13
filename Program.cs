while (true)
{
    Console.WriteLine("Digite um numero:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("O numero digitado é par!!");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("O numero digitado é impar!!");
        Console.ReadLine();
    }
    Console.Clear();
}
