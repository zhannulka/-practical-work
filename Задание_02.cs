// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите y для точки А: ");
int yA  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x для точки А: ");
int xA  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z для точки А: ");
int zA  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y для точки B: ");
int yB  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x для точки B: ");
int xB  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z для точки B: ");
int zB  = Convert.ToInt32(Console.ReadLine());

 double distance = Math.Round(Math.Pow((Math.Pow(xA - xB, 2) +
                         Math.Pow(yA - yB, 2) +
                         Math.Pow(zA - zB, 2) *
                                   1.0), 0.5), 2);
    Console.WriteLine("Расстяние между двумя точками = " + distance);

