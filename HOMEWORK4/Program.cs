/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int RandomArray(int size, int min, int max)
{
    int[] a = new int[size];
    int count = 0;
    for(int i = 0; i <size; i++)
    {
        a[i] = new Random().Next(min, max);
        Console.Write(a[i] + " ");
        if (a[i] % 2 == 0)
        {
            count++;
        }
    }
   return count;
   Console.WriteLine(count);
    
}
Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четных чисел = " + (RandomArray(size, min, max)));
Console.WriteLine();

*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int RandomArray(int size, int min, int max)
{
    int[] a = new int[size];
    int sum = 0;

    for(int i = 0; i <size; i++)
    {
    a[i] = new Random().Next(min, max);
    Console.Write(a[i] + " ");
        if (i % 2 != 0)
            {
                sum = sum + a[i];
            }
    }
   return sum;
   Console.WriteLine(sum);
    
}
Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел на нечетных позициях = " + (RandomArray(size, min, max)));
Console.WriteLine();

/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


 void MayArray (int lengthArray ) 
  { 
       double [] a = new double[ lengthArray ]; 
       double max = 0; 
       double min = 0; 
       for (int i = 0; i < lengthArray; i ++ ) 
      { 
           a[i] = new Random().NextDouble (); 
           Console . Write ( a [ i ] + "   " ); 
           if  (a [i] > max) 
          { 
               max = a [i]; 
          } 
      } 
       min = max; 
       for  (int i = 0; i < lengthArray; i ++ ) 
      { 
           if (a[i] <  min ) 
          { 
               min = a [i]; 
          } 
      } 
       Console . WriteLine (); 
       Console . WriteLine ( " Max =  "   + ( max )); 
       Console . WriteLine ( " Min =  "   + ( min )); 
       Console . WriteLine ( " Max - Min =  " + ( max - min )); 
  } 
  
  Console.Write(" Input array lenght:  "); 
  int length = Convert.ToInt32(Console.ReadLine ()); 
  MayArray (length); 
  Console.WriteLine();
*/


 