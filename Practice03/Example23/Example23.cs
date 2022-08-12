/* Задача 23: Напишите программу, 
которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.WriteLine("Чтобы увидеть все кубы числа от 1 до определённого целого числа, пожалуйста, введите это число. ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (num < 1) Console.WriteLine("Вы ввели неверное число. Пожалуйста, введите число больше 1.");
if (num >= 1)
{
   while (i <= num)
   {
       int square = i * i;
       int res = square * i;
       Console.WriteLine($"{i}  {res}");
       i++;
    }
}
