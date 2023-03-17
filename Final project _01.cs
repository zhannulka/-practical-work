// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

class Program {
static int ReadInt(string prompt)
{
Console.WriteLine(prompt);
return Convert.ToInt32(Console.ReadLine());
}

static void WriteNumbers(int num)
{
if (num == 0) return;
Console.Write(num+" ");
WriteNumbers(num-1);
}
 static void Main(string[]  args)
{
WriteNumbers(ReadInt("Введите число: "));
}
}

