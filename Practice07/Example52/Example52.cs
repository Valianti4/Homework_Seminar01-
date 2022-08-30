/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Чтобы узнать среднее арифметическое каждого столбца двумерного массива, нажмите клавишу Enter.");
Console.ReadLine();
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 2}|");
            else Console.Write($"{matrix[i, j], 2}");
        }
        Console.WriteLine("|");
    }
        
}

void ColMeanMatrix(int[,] matrix)
{
    double res = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            res = sum / matrix.GetLength(0);            
        }        
        Console.Write($"{Math.Round(res, 1)}. ");
    }    
}   

int[,] array2D = CreateMatrix(5, 4, 0, 99);
PrintMatrix(array2D);
Console.Write($"Среднее арифметическое каждого столбца: ");
ColMeanMatrix(array2D);