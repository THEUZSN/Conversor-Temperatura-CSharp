using System;
using System.Linq;

namespace Exercício_1;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o Primeiro nome");
        var nome1 = Console.ReadLine();

        Console.WriteLine("Digite o segundo nome");
        var nome2 = Console.ReadLine();

        Console.WriteLine("Digite o terceiro nome");
        var nome3 = Console.ReadLine();

        Console.WriteLine("Digite o ultimo nome");
        var nome4 = Console.ReadLine();

        Console.WriteLine(nome1.Reverse());
    }

}
