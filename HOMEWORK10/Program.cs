
// Задайте массив строк. Напишите программу,которая считает кол-во слов в массиве, начинающихся на гласную букву. 
/*
 int CountVowel(string[] array) 
 { 
     char[] vowelLetters = {'a', 'e', 'i', 'o', 'u', 'y'}; 
     int count = 0; 
     for (int i = 0; i < array.Length; i++) 
     { 
         for (int j = 0; j < vowelLetters.Length; j++) 
         { 
             if(array[i][0] == vowelLetters[j]) 
             { 
                 count++; 
             } 
         } 
     } 
     return count; 
 } 
  
 string[] words = {"reye", "qwe", "awer", "sert", "rty", "tyu", "art"}; 
  
 Console.WriteLine(); 
 Console.WriteLine("колличество слов, начинающихся с гласной буквы: " + CountVowel(words)); 
 Console.WriteLine(); 
*/
 
//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив,  
//объединяя элементы исходного массива попарно. 

  

 string[] CombineWords(string[] array) 
 { 
     string[] CombiArray = new string[array.Length / 2]; 
     for (int i = 0, j = 0; i < CombiArray.Length; i++, j += 2) 
     { 
         CombiArray[i] = array[j] + array[j + 1]; 
     } 
     return CombiArray; 
 } 
  
 void PrintArrayString(string[] array) 
 { 
     Console.Write("{"); 
     for (int i = 0; i < array.Length; i++) 
     { 
         Console.Write('"' + array[i] + '"'); 
         if(i == array.Length - 1) 
         { 
             Console.Write("}"); 
         } 
         else 
         { 
             Console.Write(", "); 
         } 
     } 
 } 
  
 string[] words = {"jlfsdk", "fsda", "saytjrm", "ssdf", "fbvsd", "sdvsv", "sga", "dgsf"}; 
  
 Console.WriteLine(); 
 PrintArrayString(words); 
 string[] newArray = CombineWords(words); 
 Console.Write("  ->  "); 
 PrintArrayString(newArray); 
 Console.WriteLine();
 
