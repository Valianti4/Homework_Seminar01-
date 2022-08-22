/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/


Console.Write("Чтобы узнать разницу между максимальным и минимальным элементами массива, нажмите клавишу Enter. ");
Console.ReadLine();
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
    int min = array[0];
    int max = array[0];
    int res = 0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i < array.Length-1) Console.Write($"{array[i]}, " );
        else Console.Write(array[i]);
        for(int j = 1; j < 6; j++)
        {
            if (array[j] < min) min = array[j];
            if (array[j] > max) max = array[j];
            res = max - min;
        }                                              
    }
    Console.Write("]");
    Console.Write($" Разница между максимальным и минимальным элементами массива равна {res}." );
}
Console.Write("");
int[] arr = CreateArray(6, -99, 99);
PrintArray(arr);