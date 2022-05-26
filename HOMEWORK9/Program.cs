// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int SummaNat(int N, int M)
{
    int sum = (N + M) / 2 * (M - N + 1);
    return sum;
}
int N = 4; 
int M = 25;
Console.WriteLine(SummaNat(N, M));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SummNum(int num, int sum)
{
    if (num == 0) return sum;
    sum += num % 10;
    return SummNum((num - num % 10) / 10, sum);
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummNum(num, 0));