/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


void SecondNumber(int num)
{

    int num1 = num / 10;
    int num2 = num1 % 10;


    Console.WriteLine(num2);

}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
SecondNumber(num);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int ThirdNumber(int num)
{
    

    if (num < 99)
    {
        Console.WriteLine(num + " -> Третьей цифры нет");
        return 0;
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }

        int num1 = num / 100;
        int num2 = (num - num1 * 100) % 10;
        Console.Write( "->" + num2);
        return (num1 * 10 + num2);
    }


}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);


/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void Week(int num)

{
    if (num   <   1   ||   num   >   7)
    {
        Console.WriteLine("Input another number");
    }
    else
    {
        if (num <= 5)
        {
            Console.WriteLine(num + "-> нет");
        }
        else
        {
            Console.WriteLine(num + "-> да");
        }
    }
}    
    Console.WriteLine("Input number between 1-7: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Week(num);
*/