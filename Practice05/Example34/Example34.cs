/* Задача 34: Задайте массив 
заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int even = 0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i < array.Length-1) Console.Write($"{array[i]}, " );
        else Console.Write(array[i]);
        if (array[i] % 2 == 0) even++;                               
    }
    Console.Write("]");
    Console.Write($" В массиве чётных чисел: {even}." );
}

Console.WriteLine("");
int[] arr = CreateArray(4, 100, 999);
PrintArray(arr);