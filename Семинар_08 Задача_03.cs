
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
} 

void MatrixRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 9); 
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


int[,] firstmatrix = new int[2, 2];
int[,] secondmatrix = new int[2, 2];
MatrixRandomNumbers(firstmatrix);
MatrixRandomNumbers(secondmatrix);
int[,] resulmatrix = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            resulmatrix[i, j] = resulmatrix[i, j] + (firstmatrix[i, k] * secondmatrix[k, j]);
        }
    }
}


Console.WriteLine("Матрица первая");
PrintMatrix(firstmatrix);
Console.WriteLine();
Console.WriteLine("Матрица вторая");
PrintMatrix(secondmatrix);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
PrintMatrix(resulmatrix);