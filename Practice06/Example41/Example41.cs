/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


Console.WriteLine("Введите несколько целых чисел, а затем нажмите клавишу Enter, чтобы узнать, какие из них больше 0.");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
int num = 0;

void PrintNumbers()
{ 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) num++;
}
Console.WriteLine($"Количество чисел больше 0 равно {num}.");
}
PrintNumbers();
