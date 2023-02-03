// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да;

 Console.WriteLine("Enter a 5-digit number: ");
            int num = int.Parse(Console.ReadLine());

            int a = num / 10000;
            int b = (num / 1000) % 10;
            int c = (num / 100) % 10;
            int d = (num / 10) % 10;
            int e = num % 10;

            if (a == e && b == d)
            {
                Console.WriteLine(num + " is a palindrome");
            }
            else
            {
                Console.WriteLine(num + " is not a palindrome");
            }

            Console.ReadKey();