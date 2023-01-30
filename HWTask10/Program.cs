// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Enter a three-digit number: ");
            int number = int.Parse(Console.ReadLine());

            int secondDigit = (number % 100) / 10;
            Console.WriteLine("The second digit is: " + secondDigit);;
