/*int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
PrintArray(FillArray(matrix));
int[,] SortArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {

                if (matr[i, j] < matr[i, k])
                {
                    int temprorary = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temprorary;
                }
            }
        }
    }
    return matr;
}



Console.WriteLine();
PrintArray(SortArray(matrix));*/

//Zadacha2

/*int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[6, 4];
PrintArray(FillArray(matrix));
int SumRows(int[,] matr)
{
    int Sum = 0;
    int Row = 0;
    int SumMin = SumLines(matr, 0);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Sum = SumLines(matr, i);

        if (Sum < SumMin)
        {
            SumMin = Sum;
            Row = i + 1;
            Sum = 0;
        }
        else Sum = 0;
    }
        return Row;
    }
    int SumLines(int[,] matr, int Row)
    {
        int SumLine = matr[Row, 0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            SumLine += matr[Row, j];
        }
        return SumLine;
    }
    Console.WriteLine($"Ряд с наименьшей суммой чисел = {SumRows(matrix)}");*/
// Zadacha3

/*int[,] InputArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return matr;
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int [,] matrixResult = new int [2, 2];
PrintArray(InputArray(matrix));
Console.WriteLine();
PrintArray(InputArray(matrix2));
void MultiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
        Console.WriteLine();
        MultiplyMatrix(matrix, matrix2, matrixResult);
        PrintArray(matrixResult);*/


//Zadacha4
/*int[,,] FillArray(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                matr[k, i, j] = new Random().Next(1, 10);
            }
        }
    }
    return matr;
}
    void PrintArray(int[,,] matr)
    {
        for (int k = 0; k < matr.GetLength(0); k++)
        {
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                for (int j = 0; j < matr.GetLength(2); j++)
                {
                    Console.Write($"{matr[k, i, j]}({k},{i},{j}) ");
                }
                Console.WriteLine();
            }
        }
    }
int[,,] matrix = new int[2, 2, 2];
PrintArray(FillArray(matrix));*/


//Zadacha5
/*int[,] Matrix(int[,] matr)
{
    int Num = 1;
    int i = 0;
    int j = 0;
    while (Num <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = Num;
        Num++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matr;
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write($"0" + $"{matr[i, j]} ");
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }
        }
        Console.WriteLine();

    }
}
int[,] matrix = new int[4, 4];
PrintArray(Matrix(matrix));*/
