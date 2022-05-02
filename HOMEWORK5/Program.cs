/*
// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen (int A, int B)
{
    int a = A;
    int b = B;
    int c = 1;
    
    for(int i = 0; i < b; i++)
    {
        c = c*a;
     
    }
    return c;
    
}


Console.Write("Input A integer number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B integer number: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = Stepen(A,B);
Console.WriteLine(result);


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int A)
{
    int sum = 0;
    int d = A;
    while  (d > 0)
    {
        sum += d % 10;
        d /= 10;

    }
    return sum;
}


Console.Write("Input A integer number: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = Sum(A);
Console.WriteLine(result);

*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int RandomArray(int size, int min, int max)
{
    int[] a = new int[size];
    int count = 0;
    for(int i = 0; i <size; i++)
    {
        a[i] = new Random().Next(min, max);
        Console.Write(a[i] + " ");
        count++;
            
    }
   return count;
       
}
Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int result = RandomArray( size, min, max);
Console.WriteLine(result);