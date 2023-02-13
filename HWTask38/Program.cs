// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76;


double[] numbers = new double[] { 3, 7, 22, 2, 78 };

double max = numbers[0];
double min = numbers[0];

  for (int i = 1; i < numbers.Length; i++)
    {
      if (numbers[i] > max)
        {
          max = numbers[i];
        }
      if (numbers[i] < min)
        {
          min = numbers[i];
        }
    }

Console.WriteLine("Difference between max and min elements: " + (max - min));
Console.ReadLine();