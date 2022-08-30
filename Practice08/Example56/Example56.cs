/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


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
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}

void SumStringMatrix(int[,] matrix)
{
     int[] res = array[];  //массив для хранения сумм строк
            int sum = 0;
            for (int i = 0; i < array; i++)
            {
                for (int j = 0; j < array; j++)
                {
                    sum += matrix[i, j];   //суммируем элементы строки
                }
                res[i] = sum; //пишем сумму в массив
                sum = 0; //обнуляем переменную
            }

            int min = 0;    //индекс строки с максимальной суммой
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (res[j] < res[min])   //если есть строка с суммой больше, то пишем в max её индекс
                    min = j;
            }
            Console.WriteLine("Номер строки с максимальной суммой элементов: "+min);
      
}   

int[,] array2D = CreateMatrix(3, 4, 0, 9);
PrintMatrix(array2D);
SumStringMatrix(array2D);