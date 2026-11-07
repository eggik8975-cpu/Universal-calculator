using System;

class Program
{
    delegate double MathOperation(double a, double b);

    static double Calculate(double a, double b, MathOperation operation)
    {
        return operation(a, b);
    }

    static void Main()
    {
        Console.WriteLine("--- Универсальный калькулятор ---");

        Console.Write("Введите первое число: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("--- Результаты вычислений ---");

        Console.WriteLine($"Сложение: {Calculate(x, y, (a, b) => a + b)}");
        Console.WriteLine($"Вычитание: {Calculate(x, y, (a, b) => a - b)}");
        Console.WriteLine($"Умножение: {Calculate(x, y, (a, b) => a * b)}");

        if (y != 0)
            Console.WriteLine($"Деление: {Calculate(x, y, (a, b) => a / b)}");
        else
            Console.WriteLine("Деление: невозможно (деление на ноль)");

        Console.WriteLine($"Остаток от деления: {Calculate(x, y, (a, b) => a % b)}");
        Console.WriteLine($"Степень (x^y): {Calculate(x, y, (a, b) => Math.Pow(a, b))}");
        Console.WriteLine($"Среднее арифметическое: {Calculate(x, y, (a, b) => (a + b) / 2)}");
        Console.WriteLine($"Максимум: {Calculate(x, y, (a, b) => Math.Max(a, b))}");
        Console.WriteLine($"Минимум: {Calculate(x, y, (a, b) => Math.Min(a, b))}");
    }
}