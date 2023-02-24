// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18;


int[,] matrix1 = {{2, 4}, {3, 2}};
int[,] matrix2 = {{3, 4}, {3, 3}};

int[,] product = MultiplyMatrices(matrix1, matrix2);

for (int i = 0; i < product.GetLength(0); i++) 
 {
  for (int j = 0; j < product.GetLength(1); j++) 
   {
    Console.Write("{0} ", product[i, j]);
   }
  Console.WriteLine();
 }

static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2) 
 {
  if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
   {
    throw new ArgumentException("Matrices cannot be multiplied");
   }

  int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

  for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
     for (int j = 0; j < matrix2.GetLength(1); j++) 
      {
       int sum = 0;
       for (int k = 0; k < matrix1.GetLength(1); k++) 
        {
         sum += matrix1[i, k] * matrix2[k, j];
        }
       product[i, j] = sum;
      }
    }

  return product;
 }
