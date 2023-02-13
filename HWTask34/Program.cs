// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2;


int[] arr = new int[10];
Random rand = new Random();

  Console.WriteLine("Array of Random Positive Three-Digit Numbers:");
  for (int i = 0; i < 10; i++)
  {
    arr[i] = rand.Next(100, 1000);
    Console.Write(arr[i] + " ");
  }

int evenCount = 0;
for (int i = 0; i < 10; i++)
 {
    if (arr[i] % 2 == 0)
    {
      evenCount++;
    }
 }

Console.WriteLine("\n\nNumber of even numbers in the array: " + evenCount);