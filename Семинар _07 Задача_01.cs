// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int ReadInt(string text) 
{
    System.Console.Write(text);                
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateMatrix(int m, int n) //функция создающая двумерный массив, Matrix потому что двумерный массив это посути матрица
{
 double[,] matrix = new double[m, n]; //запятая в квадратных скобках означает что массив двумерный. если бы были три запятых, то массив бал бы трехерный
  


    for(int i= 0; i < m; i++)  //для прохождения по массиву используються два цикла for один вложен в другой
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;// matrix[i,j] = random.NextDouble()*100;обращение к каждому элементу матрицы
        } 
    }
    return  matrix; //возврат матрицы
}

void PrintMatrix(double[,] matr) //функция вывода матрицы
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}
int m = ReadInt("Введите количетсво строк матрицы: "); 
int n = ReadInt("Введите количество столбцов матрицы: "); 
var myMatrix = GenerateMatrix(m, n); 
PrintMatrix(myMatrix); 


