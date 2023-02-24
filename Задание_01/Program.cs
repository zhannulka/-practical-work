
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <= 999)
 { System.Console.WriteLine("Число введено корректно"); }
else { System.Console.WriteLine($"Число {number} не являеться трёхзначным"); }
int first = number % 100;
int second = first / 10;
System.Console.WriteLine($"Вторая цифра числа {second}");


