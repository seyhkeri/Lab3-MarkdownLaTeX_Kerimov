using System;

namespace MarkdownDemo
{
    class FormatDemo
    {
        static void Main(string[] args)
        {
            // **Жирный текст**
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            // *Курсив*
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            // ***Жирный курсив***
            double sum = number1 + number2;
            // ~~Зачёркнутый~~
            Console.WriteLine($"***Результаты операций: {sum}***");
        }
    }
}
