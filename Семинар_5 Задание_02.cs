// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]= rand.Next(size); 
    }
    return array;
}

void PrintArray(int[]array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Sumelemets(int[]array, out int sum)

{
    sum=0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==1)
        sum+=array[i];
    }
}


var myArray = GenerateArray(4);
PrintArray(myArray);
Sumelemets(myArray, out int sum);

System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");
