// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое целое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Первое число = ");
Console.WriteLine(a);
Console.Write("Второе число = ");
Console.WriteLine(b);
Console.Write("Третье число = ");
Console.WriteLine(c);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("Я нашла для вас максимальное число. Им является число ");
Console.WriteLine(max);
Console.Write("Хорошего дня!:) ");