Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine($"\nВведите размер массива N nM nP:");
int n = InputNumbers("Введите N: ");
int m = InputNumbers("Введите M: ");
int p = InputNumbers("Введите P: ");
Console.WriteLine($"");

int[,,] matrin= new int[n, m,p];
CreateArray(matrix);
WriteArray(matrix);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={matrix[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] matrix)
{
  int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int n= 0; n< matrix.GetLength(0); n++)
  {
    for (int m= 0; m < matrix.GetLength(1); m++)
    {
      for (int p = 0; p< matrix.GetLength(2); p++)
      {
        matrix[n, m, p] = temp[count];
        count++;
      }
    }
  }
}

