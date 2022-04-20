
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(int num)
{
    int num1 = num/10000;
    int num2 = (num - num1*10000)/1000;
    int num3 = (num - (num1 * 10000 + num2 * 1000))/100;
    int num4 = (num - (num1 * 10000 + num2 * 1000 + num3 * 100))/10;
    int num5 = num%10;

    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine(num + " is Palindrom");
    }
    else
    {
        Console.WriteLine(num + " is not Palindrom");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);


/*

   // Задача 21  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

   double Dlinna (double xA, double yA, double zA, double xB, double yB, double zB)
   {
       double lenght = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
       return lenght;
   }

   Console.WriteLine("Input xA: ");
   double xA = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Input yA: ");
   double yA = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Input zA: ");
   double zA = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Input xB: ");
   double xB = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Input yB: ");
   double yB = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Input zB: ");
   double zB = Convert.ToDouble(Console.ReadLine());

   double result = Dlinna(xA, yA, zA, xB, yB, zB);
   Console.WriteLine("Lenght between A & B: " + result);


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.Write(i*i*i + " , ");
        i++;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

CubTable(number);

*/



