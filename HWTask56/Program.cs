// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка;

int[,] arr = new int[,] 
 {
  { 1, 4, 7, 2 },
  { 5, 9, 2, 3 },
  { 8, 4, 2, 4 },
  { 5, 2, 6, 7 }
 };

int minSum = int.MaxValue;
int minIndex = -1;
  for (int i = 0; i < arr.GetLength(0); i++) 
   {
    int sum = 0;
     for (int j = 0; j < arr.GetLength(1); j++) 
      {
       sum += arr[i, j];
      }
        if (sum < minSum) 
          {
            minSum = sum;
            minIndex = i;
          }
   }

Console.WriteLine($"Row with the smallest sum: {minIndex + 1}");