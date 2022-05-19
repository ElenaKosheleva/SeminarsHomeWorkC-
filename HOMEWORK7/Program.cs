// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*

void PrintMatrix (double [ , ] matrix)
{
    Console.WriteLine();
    for (int  i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[ , ] CreateMatrix (int m, int n)
{
    double[ , ] matrix = new double [m,n];
    for (int i = 0; i < matrix.GetLength(0); i ++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i,j] = Math.Round((1 + 14)*new Random().NextDouble(), 3);
        }
    }
    PrintMatrix(matrix);
    return matrix;
}
CreateMatrix (4,5);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void PrintMatrix (double [ , ] matrix)
{
    Console.WriteLine();
    for (int  i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i,j] + "    ");
        }
        Console.WriteLine();
    }
}
double[,] Array(int size1, int size2)
{
    double[,] matrix = new double[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 15 - 10, 1);
        }
    }
    PrintMatrix(matrix);
    return matrix;
}
double CheckIndex(double[,] Array, int index1, int index2)
{
    if (index1 <= Array.GetLength(0) - 1 && index2 <= Array.GetLength(1) - 1
        && index1 >= 0 && index2 >= 0)
        {
             return Array[index1, index2];
        }
    return 99;
}
int size1 = new Random().Next(1, 20);
int size2 = new Random().Next(1, 20);
Console.Write("Матрица размером: " + size1 + "x" + size2);
Console.WriteLine();
double[,] MyArray = Array(size1, size2);
Console.Write("введите номер строки не более  " + (size1 - 1) + ": ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца не более  " + (size2 - 1) + ": ");
int index2 = Convert.ToInt32(Console.ReadLine());
double checkResult = CheckIndex(MyArray, index1, index2);
if (checkResult == 99) { Console.WriteLine(" Элемент не найден "); }
else { Console.WriteLine(" Значение элемента: " + MyArray[index1, index2]); }






// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
void PrintMatrix (int [ , ] matrix)
{
    Console.WriteLine();
    for (int  i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i,j] + " ");
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

void GetArithmeticMean(int[,] array)
{
    double sum = 0;
    double[] result = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        sum /= array.GetLength(0);
       
        Console.Write(Math.Round(sum, 1) + "; ");
        sum = 0;
    }
    Console.WriteLine();
}

Console.WriteLine("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

GetArithmeticMean(CreateMatrix(M, N));
*/