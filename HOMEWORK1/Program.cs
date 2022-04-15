/*
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
    Console.WriteLine("max = " +  num1 );
else
    Console.WriteLine("max = " +  num2 );



// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
else 
{
    max = num1;
}
if (max < num3)
{
    max = num3;
}

Console.WriteLine("MAX = " +  max );



// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input first integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine( num + " число четное ");
else
    Console.WriteLine( num + " число не четное ");




// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if (num == 0)
{
    Console.Write(" введите другое число ");
}
if (num > 0)
{
    current = 2;

    while (current <= num)
    {
        Console.Write(current + " ");

        current = current + 2;
    }
}


if (num < 0)
{
    current = -2;

    while (current >= num)
    {
        Console.Write(current + " ");

        current = current - 2;
    }
}

*/
