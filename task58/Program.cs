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
void FillArray(int[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             matr[i,j] = new Random().Next(1,10);
         }
     }
}
int[,] Multiplie(int[,] matrFirst, int[,] matrSecond)
{
    int[,] result = new int[matrFirst.GetLength(0), matrSecond.GetLength(1)];
    for (int i = 0; i < matrFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrSecond.GetLength(1); j++)
        {
            for (int k = 0; k < matrSecond.GetLength(0); k++)
            {
                result[i,j] += matrFirst[i,k] * matrSecond[k,j];
            }
        }
    }
    return result;
}
Console.Write("Введите колличество строк первой матрицы: ");
int rowsFirstArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов первой матрицы: ");
int columsFirstArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество строк второй матрицы: ");
int rowsSecondArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов второй матрицы: ");
int columsSecondArray = Convert.ToInt32(Console.ReadLine());
int[,] arrayFirst = new int[rowsFirstArray,columsFirstArray];
int[,] arraySecond = new int[rowsSecondArray,columsSecondArray];
FillArray(arrayFirst);
Console.WriteLine("Первая матрица: ");
PrintArray(arrayFirst);
Console.WriteLine();
FillArray(arraySecond);
Console.WriteLine("Вторая матрица: ");
PrintArray(arraySecond);
Console.WriteLine();
if (arrayFirst.GetLength(1) == arraySecond.GetLength(0))
{
    int [,] multiplieArray = Multiplie(arrayFirst, arraySecond);
    PrintArray(multiplieArray);
} 
else Console.WriteLine("Матрицы нельзя перемножить");

