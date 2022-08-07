// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2) 
{
    int max = num1;
    int min = num2;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
else
{
    int max = num2;
    int min = num1;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
Console.WriteLine("Программа сравнила введённые вами числа. Хорошего дня! ");