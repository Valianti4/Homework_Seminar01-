// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число, чтобы вывести третью цифру этого числа. ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= -99 && num <= 99) 
Console.WriteLine("Третьей цифры нет. Пожалуйста, введите минимум трёхзначное целое число. ");
else
{
    while (true)
    {
        int temp = num % 100;
        int res = temp % 10;
        num = num / 10;
        if (num <= -100 || num >= 100)
            continue;
        else
        {
            res = temp % 10;
            Console.WriteLine($"Третья цифра этого числа равна {Math.Abs(res)}. ");
            Console.WriteLine("Хорошего дня!:) ");
            break;
        }
    }
}