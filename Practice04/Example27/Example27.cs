/* Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

while (true)
{
    int res = num % 10;
    num = num / 10;
Console.WriteLine($"{res}");
}
