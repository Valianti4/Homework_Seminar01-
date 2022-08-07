// Задача 2: Напишите программу, 
// которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое целое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Первое число = ");
Console.WriteLine(a);
Console.Write("Второе число = ");
Console.WriteLine(b);

if(a > b) 
{
    int max = a;
    int min = b;
    Console.Write("Максимальное число = ");
    Console.WriteLine(max);
    Console.Write("Минимальное число = ");
    Console.WriteLine(min);
}
else
{
    int max = b;
    int min = a;
    Console.Write("Максимальное число = ");
    Console.WriteLine(max);
    Console.Write("Минимальное число = ");
    Console.WriteLine(min);
}
Console.WriteLine("Программа сравнила введённые вами числа. Хорошего дня! ");