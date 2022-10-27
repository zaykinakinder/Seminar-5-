Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int range = InputNumbers ("Введите диапазон");
int [,] matrix = new int [n,m];
FillArrayRandomNumbers(matrix);

int [,]array = new int [m,n];
CreateArray (array);
WriteArray (array);

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

Console.WriteLine($"Новый массив:");
OrderLines (array);
WriteArray (array);

void OrderLines(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            for (int k =0; k< array.GetLength (1)-1;k++)
            {
                if (array[i,k]<array [i, k+1])
                {
                    int temp = array [i, k+1];
                    array [i, k+1]=array [i,k];
                    array [i,k]=temp;

                }
            }
        }
    }
}

int InputNumbers (string input)
{

Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}