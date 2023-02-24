// // // Задача 19
// // // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // // 14212 -> нет
// // // 12821 -> да
// // // 23432 -> 


Console.WriteLine("Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());
if(number <= 100000 && number > 10000)
{
  int remineder, newnamber = 0;
int temp = number;
while (number > 0)
{
remineder = number %  10;
newnamber = newnamber * 10  + remineder;
number = number / 10;
}
if (temp == newnamber)
 {
Console.WriteLine($"Число {temp} палиндром ");
 }
else
{
Console.WriteLine($"Число {temp} не палиндром ");}}
    
else
{
  Console.WriteLine ("Вы ввели не пятизначное число, пожалуйста повторите ввод");}

