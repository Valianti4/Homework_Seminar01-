/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("Чтобы узнать степень B из числа А, сначала введите целое число А. ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А теперь введите целое натуральное число В. ");
int num2 = Convert.ToInt32(Console.ReadLine());

int DegreeNumbers(int num1)
{
    int degree = 1;
    for (int i = 1; i <= num2; i++)
        {
            degree *= num1;
        }
    return degree;
}

if (num2 > 0)
{
    int res = DegreeNumbers(num1);
    Console.WriteLine($"Число {num1} в {num2} степени равно {res}.");
}
else 
{
    Console.WriteLine("Введённое число не является натуральным. Пожалуйста, введите целое число больше нуля. ");
}