// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3;

int a, b;
Console.WriteLine("Enter the first number:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
b = int.Parse(Console.ReadLine());

if(a > b) {
     Console.WriteLine("The larger number is: " + a);
     Console.WriteLine("The smaller number is: " + b);
} else {
     Console.WriteLine("The larger number is: " + b);
     Console.WriteLine("The smaller number is: " + a);
  
}

