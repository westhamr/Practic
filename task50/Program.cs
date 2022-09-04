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
void FindNumberInArray(int[,] matr,int rows, int colums)
{
    if(rows > matr.GetLength(0) || colums > matr.GetLength(1))
            Console.WriteLine($"Данного числа нет в масиве");
    else Console.WriteLine(matr[rows-1,colums-1]);
}
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colum = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5,5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindNumberInArray(matrix, row, colum);
