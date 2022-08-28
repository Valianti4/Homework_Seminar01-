/* Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
*/


Console.Write("Введите строку элемента массива и нажмите клавишу Enter:");
int num1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец элемента массива и нажмите клавишу Enter:");
int num2 = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] CreateMatrix (int row, int col, int min, int max) 
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
        
}

void FindElemMatrix(int[,] matrix)
{
    if (num1 > matrix.GetLength(0) - 1 | num2 > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента в массиве нет. ");
    }
    else
    {
        Console.WriteLine($"Значение элемента массива равно {matrix[num1, num2]}. ");
    }
}   

int[,] array2D = CreateMatrix(5, 4, 0, 99);
PrintMatrix(array2D);
FindElemMatrix(array2D);