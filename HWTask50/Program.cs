// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет;

int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int rows = array.GetLength(0);
int cols = array.GetLength(1);

Console.Write("Enter the row position: ");
int rowPos = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int colPos = int.Parse(Console.ReadLine());

 if (rowPos < 0 || rowPos >= rows || colPos < 0 || colPos >= cols)
  {
   Console.WriteLine("There is no such element in the array.");
  }
 else
   {
    int element = array[rowPos, colPos];
    Console.WriteLine($"The value of the element at position ({rowPos}, {colPos}) is {element}.");
   }
