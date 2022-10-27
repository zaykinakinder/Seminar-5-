Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,m];
FillArrayRandomNumbers(matrix);

 for (int j = 0; j < matrix.GetLength(1); j++)
        {
           double average = 0;
            for (int i=0; i<matrix.GetLength(0);i++)
            {
                average =(average+matrix[i,j]);

            }
            average = average/n;
            Console.Write(average +";");
        }
        Console.WriteLine();
        PrintArray(matrix);
       
       
       
        void FillArrayRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
