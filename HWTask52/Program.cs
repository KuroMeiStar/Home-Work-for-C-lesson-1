// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.;



int[,] array = new int[,] { {1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};
int numRows = array.GetLength(0);
int numCols = array.GetLength(1);
double[] columnMeans = new double[numCols];

 for (int j = 0; j < numCols; j++) 
  {
   double sum = 0;
 for (int i = 0; i < numRows; i++) 
   {
    sum += array[i,j];
   }
   columnMeans[j] = sum / numRows;
  }

 for (int j = 0; j < numCols; j++) 
    {
     Console.WriteLine("Arithmetic mean of column {0}: {1}", j+1, columnMeans[j]);
    }