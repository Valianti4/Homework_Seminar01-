﻿// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Чтобы увидеть все чётные целые числа от 1 до определённого целого числа, пожалуйста, введите это число. ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{
   if (i % 2 == 0)
   Console.Write("{0}; ", i);
   i++;
}
if (num < 1)
{
    Console.WriteLine("Вы ввели неверное число. Пожалуйста, введите число больше 1.");
}