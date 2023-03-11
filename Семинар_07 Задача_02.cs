// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет




int rows = ReadInt("Введите номер строки: ");
int colums = ReadInt("Введите номер столбца: ");
int[,] numbers = new int[4, 3];
FillArray(numbers);
PrintArray(numbers);

 int ReadInt(string text) 
{
     System.Console.Write(text);                   
     return Convert.ToInt32(Console.ReadLine());
 }

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} - такого элемента в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




