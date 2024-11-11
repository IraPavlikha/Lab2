using System;

class Program
{
    static void Main(string[] args)
    {
        // Введення значень для x1Min, x1Max, dx1, x2Min, x2Max, dx2
        Console.WriteLine("Введіть мінімальне значення x1 (x1Min):");
        double x1Min = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть максимальне значення x1 (x1Max):");
        double x1Max = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть крок зміни x1 (dx1):");
        double dx1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть мінімальне значення x2 (x2Min):");
        double x2Min = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть максимальне значення x2 (x2Max):");
        double x2Max = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть крок зміни x2 (dx2):");
        double dx2 = double.Parse(Console.ReadLine());

        // Ініціалізація змінної для суми додатних значень функції
        double sumPositiveY = 0;

        // Зовнішній цикл для x1
        for (double x1 = x1Min; x1 <= x1Max; x1 += dx1)
        {
            // Внутрішній цикл для x2
            for (double x2 = x2Min; x2 <= x2Max; x2 += dx2)
            {
                // Обчислення значення функції y
                double y = (Math.Sqrt(Math.Pow(x1, 3) + Math.Pow(x2, 5)) / 1000) + 65;

                // Виведення значень x1, x2 та y з точністю до 2 знаків після коми
                Console.WriteLine($"x1 = {x1:F2}\t x2 = {x2:F2}\t y = {y:F2}");

                // Якщо y додатнє, додаємо його до суми
                if (y > 0)
                {
                    sumPositiveY += y;
                }
            }
        }

        // Виведення суми всіх додатних значень функції
        Console.WriteLine($"Сума всіх додатних значень f(x1, x2): {sumPositiveY:F2}");

        // Завершення роботи програми
        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}