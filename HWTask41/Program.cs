// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3;

Console.Write("Enter the value of M: ");
int M = int.Parse(Console.ReadLine());

int count = 0;

 for (int i = 0; i < M; i++)
   {
     Console.Write("Enter a number: ");
     int num = int.Parse(Console.ReadLine());

      if (num > 0)
        {
         count++;
        }
   }

Console.WriteLine("You entered {0} numbers greater than 0.", count);

Console.ReadKey();
