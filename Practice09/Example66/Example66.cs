﻿/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Чтобы узнать сумму натуральных чисел между числами M и N, введите целое положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чтобы узнать сумму натуральных чисел между числами M и N, введите целое положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;
    else if (N == 0) return (M * (M + 1)) / 2;
    else if (M == N) return M;
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);
}
Console.WriteLine($"Сумма натуральных чисел между {M} и {N} равна {SumNumbers(M, N)}.");