// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным;
// 6 -> да
// 7 -> да
// 1 -> нет

 Console.WriteLine("Enter a digit (1-7) to indicate the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 6 || day == 7)
                Console.WriteLine("It's a weekend!");
            else
                Console.WriteLine("It's not a weekend.");