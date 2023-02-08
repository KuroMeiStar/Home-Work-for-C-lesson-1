// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter number A: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

double result = 1;
for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine("Result: " + result);
