// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125;

Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Number\tCube");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\t{1}", i, i * i * i);
            }
            Console.ReadLine();