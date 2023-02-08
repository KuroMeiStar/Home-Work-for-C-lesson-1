// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33];

 
int[] numbers = new int[8] { 4, 7, 3, 6, 5, 9, 1, 2 };
    
    Console.WriteLine("Array elements are:");
    
    foreach (int i in numbers)
            
  {
    Console.Write(i + " ");
  }
            
Console.ReadLine();
