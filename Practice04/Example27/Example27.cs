/* Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.WriteLine("Введите любое целое число. ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0; 
if (num == 0)
{
    Console.WriteLine("Сумма цифр равна 0. ");
}
else
{
    while(num < 0 || num > 0)
    {   
        int temp = num % 10;
        i = i + temp;
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр равна {Math.Abs(i)}. ");
}