﻿// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите целое число в диапазоне от 1 до 7. ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 7)
{ 
Console.WriteLine("Вы ввели неверное число. Пожалуйста, введите целое число в диапазоне от 1 до 7. ");
}
else
{
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine("Этот день не является выходным. ");
    } 
    else 
    {
    Console.WriteLine("Этот день является выходным. ");
    }
} 

/* 
int temp = num % 10; Нахождение пятой цифры.
int res = temp % 10;

int temp = num % 100; Нахождение четвёртой цифры.
int res = temp / 10;

int temp = num / 100; Нахождение третьей цифры.
int temp2 = temp % 10; 

int temp = num / 10;
int temp2 = temp / 100; Нахождение второй цифры.
int res = temp2 % 10;

int temp = num / 100; Нахождение первой цифры.
int res = temp / 100;
*/


// Console.WriteLine("Расстояние между точками равно: {0: #.##} ", res);