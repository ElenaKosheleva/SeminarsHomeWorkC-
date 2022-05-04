/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

double[] CreateArray(double size)
{
    double[] array = new double[size];
    for(double i = 0; i <size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
   return array;  
    
}
void ShowArray(double[] array)
{
    for(double i = 0; i < array.Length; i++ )
        Console.Write(array[i] + " ");
}

double CountPlus(double[] array)
{
double count = 0;
for(double i = 0; i < array.Length; i++ )
if(array[i] > 0)
count++;
return count;
}

Console.WriteLine("Input size: ");
double size = Convert.ToDouble(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);
CountPlus(myArray);
Console.WriteLine("Положительных чисел в массиве: " + CountPlus(myArray));



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Convert2(double num)
{
    string s = string.Empty;
    double N = num;
    while (N>0)
    {
       s = N%2+s;
       N = N/2;

    }


    Console.WriteLine(s);

}


Console.WriteLine("Input number: ");
double num = Convert.ToDouble(Console.ReadLine());
Convert2(num); 
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double TPeresech(double b1, double k1, double b2, double k2)
{
    double x;
    x=(b2 - b1)/(k1-k2);
    return x;
    
}

Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input 2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double x1 = TPeresech( b1, k1, b2, k2);
double y = k1 * x1 + b1;
Console.WriteLine(" Точка пересечения " + x1 + " " + y);