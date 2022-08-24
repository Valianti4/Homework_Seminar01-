/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.Write("Для того, чтобы найти точку пересечения двух прямых, введите значение для переменной k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для переменной b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для переменной k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для переменной b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

void IntersectionPoint()
{ 
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;   
    Console.WriteLine($"Прямые пересекаются в точке A({Math.Round(x, 2)}; {Math.Round(y, 2)}). ");
} 

 IntersectionPoint();