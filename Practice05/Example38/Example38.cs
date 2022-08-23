/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/


Console.Write("Чтобы узнать разницу между максимальным и минимальным элементами массива, нажмите клавишу Enter. ");
Console.ReadLine();
double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() + rnd.Next(min, max);
    }
    return array;
}

void PrintArray(double[] array)
{    
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i < array.Length-1) Console.Write($"{Math.Round(array[i], 2)}, " );
        else Console.Write(Math.Round(array[i], 2));        
    }
    Console.Write("]");                                              
}    

double[] DifArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    double res = 0;
    for(int j = 1; j < array.Length; j++)
        {            
            if (array[j] < min) min = array[j];
            if (array[j] > max) max = array[j];
            res = max - min;            
        }
        Console.Write($" Разница между максимальным и минимальным элементами массива равна {Math.Round(res, 2)}." );
        return array;
}   

Console.Write("");
double[] arr = CreateArray(5, -1, 20);
PrintArray(arr);
DifArray(arr);