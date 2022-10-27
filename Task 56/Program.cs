Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,m];
FillArrayRandomNumbers(matrix);

int MinSum=0;


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


int SumLine = SumLineElements(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (SumLine > tempSumLine)
  {
    SumLine = tempSumLine;
    MinSum = i;
  }
}

Console.WriteLine($"\n{MinSum+1} - строкa с наименьшей суммой ({SumLine}) элементов ");

int SumLineElements(int[,] matrix, int i)
{
  int SumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    SumLine += matrix[i,j];
  }
  return SumLine;
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