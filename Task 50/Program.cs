Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [10,10];
FillArrayRandomNumbers(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrix[n-1,m-1]}");
}

PrintArray(matrix);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}