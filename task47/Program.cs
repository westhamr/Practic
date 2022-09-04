void PrintArray(double[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             Console.Write("{0,6:F2}", matr[i, j]);
         }
         Console.WriteLine();
     }
 }
 void FillArray(double[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             matr[i,j] = new Random().NextDouble() * 100;
         }
     }
}
Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m,n];
FillArray(matrix);
PrintArray(matrix);