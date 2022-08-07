// Задача 2: Напишите программу, 
// которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое целое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число = {a}. ");
Console.WriteLine($"Второе число = {b}. ");

if (a > b) 
{
    int max = a;
    int min = b;
    Console.WriteLine($"Максимальным числом является число {max}. ");
    Console.WriteLine($"Минимальным числом является число {min}. ");    
}
else
{
    int max = b;
    int min = a;
    Console.WriteLine($"Максимальным числом является число {max}. ");
    Console.WriteLine($"Минимальным числом является число {min}. ");    
}
if (a == b)
{
    int max = a;
    int min = b;
    Console.WriteLine($"{max} = {min}, поэтому эти числа равны. ");
}
Console.WriteLine("Я (в смысле программа) сравнила для вас введённые вами числа. ");
Console.Write("Хорошего дня!:)");