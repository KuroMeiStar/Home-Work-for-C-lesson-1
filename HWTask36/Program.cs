// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0;


int[] numbers = { 3, 7, 23, 12 };
int sum = 0;

 for (int i = 0; i < numbers.Length; i++)
  {
    if (i % 2 != 0)
     {
        sum += numbers[i];
     }
  }

Console.WriteLine("The sum of elements standing in odd positions is: " + sum);
Console.ReadLine();