// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void InputMatrix (int [,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
    for (int j=0; j<matrix.GetLength(1);j++)
    {
    matrix[i,j]= new Random().Next (-10,11);
    Console.Write(matrix[i,j]+" \t");

    }
    Console.WriteLine();
    }
}
Console.WriteLine("Введите колво строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колво столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,]matrix=new int [n,m];
InputMatrix (matrix);