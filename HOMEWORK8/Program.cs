// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

void PrintMatrix (int [ , ] matrix)
{
    Console.WriteLine();
    for (int  i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(" \t " + matrix[i,j]);
        }
        Console.WriteLine();
    }
}

int[ , ] CreateMatrix (int m, int n)
{
    int[ , ] matrix = new int [m,n];
    for (int i = 0; i < matrix.GetLength(0); i ++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i,j] = new Random().Next(100);
        }
    }
    PrintMatrix(matrix);
    return matrix;
}

int[,] NewMatrix(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, minPosition]) minPosition = k; 
            }
            int tmp = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = tmp;
        }

    }
    PrintMatrix(array);
    return array;
}

Console.WriteLine("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

NewMatrix(CreateMatrix(M, N));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void rowNumber(int[,] array)
{
    int index = 1;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            index = i + 1;
        }
    }
    Console.WriteLine("Min line is: " + (index));
    
    }

rowNumber(CreateMatrix(M, N));

// Задача 62. Заполните спирально массив 4 на 4.

int[,] CreateSpriralArray(int m, int n)
{
    int[,] array = new int[4, 4];
    int row = 0, column = 0, deltaCol = 1, deltaRow = 0, limit = 0, way = 0;
    
    limit = n;

    for (int i = 0; i < m * n; i++)
    {
        array[row, column] = i + 1;

        limit--;
        if(limit == 0 && way%2 == 0)
        {
            limit = m - way / 2 - 1;
            (deltaCol, deltaRow) = (-deltaRow, deltaCol);   
            way++;
        }
        if(limit == 0 && way%2 != 0)
        {
            limit = n - way / 2 -1;
            (deltaCol, deltaRow) = (-deltaRow, deltaCol);
            way++;
        }
        row += deltaRow;
        column += deltaCol;

    }

    return array;
}

PrintMatrix(CreateSpriralArray(4, 4));
