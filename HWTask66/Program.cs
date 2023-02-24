// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30;


int M = 4, N = 8;
int sum = 0;

for (int i = M; i <= N; i++)
 {
  sum += i;
 }

Console.WriteLine("The sum of natural numbers from {0} to {1} is {2}", M, N, sum);
