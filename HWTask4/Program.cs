﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



 int num1, num2, num3;
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        num3 = Convert.ToInt32(Console.ReadLine());

        int result = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine("The maximum number is: " + result);;
