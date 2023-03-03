// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]= rand.Next(leftRange, rightRange); 
    }
    return array;
}

void PrintArray(int[]array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Sumevennumber(int[]array, out int sumnumber)

{
    sumnumber=0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        sumnumber++;
    }
}


var myArray = GenerateArray(4, 100, 1000);
PrintArray(myArray);
Sumevennumber(myArray, out int sumnumber);

System.Console.WriteLine($"Количество четных чисел в массиве: {sumnumber}");



