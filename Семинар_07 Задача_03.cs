// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text) 
{
    System.Console.Write(text);                
    return Convert.ToInt32(Console.ReadLine());
}



int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = new Random().Next(-10, 10);

            
        }

    }
    return matrix;
}

// int  Average (int[,] matrix)

// {
// double average = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//        average = (average + matrix[i, j]); // sum += matrix[i,j];
// average = average/n;
//     }
    
// }
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");

        }
        System.Console.WriteLine();
    }

}

// int  Average (int[,] matrix);

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         avarage = (avarage + matrix[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();



int m = ReadInt("Введите количетсво строк матрицы: "); 
int n = ReadInt("Введите количество столбцов матрицы: ");
int [,] matrix = CreateMatrix(4,6);
PrintMatrix(matrix);
PrintArray(numbers);