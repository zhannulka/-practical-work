// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76 

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
FillArrayRandomNumbers(number);
PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] > max)
        {
            max = number[i];
        }
    if (number[i] < min)
        {
            min = number[i];
        }
}

Console.WriteLine($"Максимальное значение элемента = {max}");
Console.WriteLine($"Минимальное значение элемента = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int j = 0; j < number.Length; j++)
        {
            number[j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int j = 0; j < number.Length; j++)
        {
            Console.Write(number[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}