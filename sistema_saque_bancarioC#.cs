using System;

class SaldoNegativoException : Exception
{
    public SaldoNegativoException(string message) : base(message) { }
}

class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        double saldo = 0;
        double saque = 0;

        Console.WriteLine("Digite o valor do seu saldo atual.");
        while (true)
        {
            try
            {
                Console.Write("- ");
                if (!double.TryParse(Console.ReadLine(), out saldo))
                    throw new FormatException();

                if (saldo < 1)
                    throw new SaldoNegativoException("O saldo nao pode ser menor que 1.");
            }
            catch (SaldoNegativoException erro)
            {
                Console.WriteLine(erro.Message);
                continue;
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um numero!");
                continue;
            }

            break;
        }

        Console.WriteLine("Digite quanto deseja sacar da sua conta.");
        while (true)
        {
            bool sair = false;
            try
            {
                Console.Write("- ");
                if (!double.TryParse(Console.ReadLine(), out saque))
                    throw new FormatException();

                if (saque > saldo)
                    throw new SaldoInsuficienteException("Saldo insuficiente para essa transacao.");
            }
            catch (SaldoInsuficienteException saldobaixo)
            {
                Console.WriteLine(saldobaixo.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um numero!");
            }
            finally
            {
                Console.WriteLine("Operacao Bancaria Finalizada");
                sair = true;
            }

            if (sair)
                break;
        }

        if (saque <= saldo)
        {
            Console.WriteLine("Transacao realizada com sucesso.");
            double sobra = saldo - saque;
            Console.WriteLine($"Sua conta agora possui R${sobra}.");
        }
    }
}
