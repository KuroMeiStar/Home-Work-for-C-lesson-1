// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет;
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

 Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int n = number;
            while (n > 0)
            {
                n /= 10;
                count++;
            }

            if (count >= 3)
            {
                int thirdDigit = (number / (int)Pow(10, count - 3)) % 10;
                Console.WriteLine("The third digit is " + thirdDigit);
            }
            else
            {
                Console.WriteLine("The number does not have enough digits to have a third digit.");
            }
        

        static int Pow(int baseNumber, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }