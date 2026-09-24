using System;

class Program
{
    static void Main()
    {
        double divisao = 0;
        double num1, num2;

        Console.WriteLine("Digite um numero:");
        while (true)
        {
            Console.Write("- ");
            if (double.TryParse(Console.ReadLine(), out num1))
                break;
            Console.WriteLine("Digite um número!");
        }

        Console.WriteLine("Digite outro número:");
        while (true)
        {
            Console.Write("- ");
            if (double.TryParse(Console.ReadLine(), out num2))
                break;
            Console.WriteLine("Digite um número!!");
        }

        try
        {
            divisao = num1 / num2;
            if (num2 == 0)
                throw new DivideByZeroException();
            Console.WriteLine($"{num1} dividido por {num2} é igual a {divisao:F20}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Impossivel dividir por 0!");
        }
        finally
        {
            Console.WriteLine("Operacao finalizada.");
        }
    }
}
