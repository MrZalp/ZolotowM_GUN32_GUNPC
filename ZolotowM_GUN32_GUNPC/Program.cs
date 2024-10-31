using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error! Invalid input.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите второе число:");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error! Invalid input.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите оператор (&, |, ^):");
        string operation = Console.ReadLine();
        int result;

        switch (operation)
        {
            case "&":
                result = a & b;
                break;
            case "|":
                result = a | b;
                break;
            case "^":
                result = a ^ b;
                break;
            default:
                Console.WriteLine("Error! Invalid operator.");
                return;
        }

        Console.WriteLine($"десятичный: {result}");
        Console.WriteLine($"Двоичный: {Convert.ToString(result, 2)}");
        Console.WriteLine($"Шестнадцатеричный: {result:X}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}


