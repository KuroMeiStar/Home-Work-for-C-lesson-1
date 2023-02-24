// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1";

int N = 8;

PrintNumbers(N);


void PrintNumbers(int n)
 {
  if (n == 0) // Base case
   {
    return;
   }
  else
   {
    Console.Write(n + " "); // Print current number
    PrintNumbers(n - 1); // Recursive call to print the next number
   }
 }

