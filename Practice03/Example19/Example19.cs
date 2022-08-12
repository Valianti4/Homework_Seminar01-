/* Задача 19: Напишите программу, 
которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да 
*/

Console.WriteLine("Введите целое пятизначное число, чтобы узнать, является ли оно палиндромом. ");
int num = Convert.ToInt32(Console.ReadLine());

int temp1 = num / 100;
int digit1 = temp1 / 100;

int temp2 = num / 10;
int temp3 = temp2 / 100;
int digit2 = temp3 % 10;

int temp4 = num / 100;
int digit3 = temp4 % 10;

int temp5 = num % 100;
int digit4 = temp5 / 10;

int temp6 = num % 10;
int digit5 = temp6 % 10;

if (num < -9999 || num > 9999)
{ 
    if (digit1 == digit5 && digit2 == digit4)
    {
    Console.WriteLine("Это число является палиндромом. ");
    Console.WriteLine("Хорошего дня!:) ");
    }
    else
    {
        Console.WriteLine("Это число не является палиндромом. ");
        Console.WriteLine("Хорошего дня!:) ");
    }
}
else
{
    Console.WriteLine("Это число не является пятизначным. Пожалуйста, введите целое пятизначное число. "); 
}


/* 
int temp = num % 10; Нахождение пятой цифры.
int res = temp % 10;

int temp = num % 100; Нахождение четвёртой цифры.
int res = temp / 10;

int temp = num / 100; Нахождение третьей цифры.
int temp2 = temp % 10; 

int temp = num / 10;
int temp2 = temp / 100; Нахождение второй цифры.
int res = temp2 % 10;

int temp = num / 100; Нахождение первой цифры.
int res = temp / 100;
*/