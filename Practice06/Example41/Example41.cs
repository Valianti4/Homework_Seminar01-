/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


Console.WriteLine("Введите через запятую несколько целых чисел, а затем нажмите клавишу Enter, чтобы узнать, какие из них больше нуля.");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
int num = 0;

int[] Numbers(int[] array)
{ 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) num++;
    }
    return array;
}

void PrintNumbers()
{
    Console.WriteLine($"Количество чисел больше нуля равно {num}.");
}

Numbers(arr);
PrintNumbers();