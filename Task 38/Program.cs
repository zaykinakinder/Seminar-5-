// See https://aka.ms/new-console-template for more informationv
void InputArray (double[]array)
{
    for (int i=0; i<array.Length;i++)
    array [i] =Math.Round(new Random().NextDouble()*10, 3);
}
double SearchMaxToArray (double []array)
{
    double maxArray=array[0];
    for(int i =1;i<array.Length;i++)
    {
        if (maxArray<array[i])
        maxArray = array[i];
    
    }
    return maxArray;
}
double SearchMinToArray (double []array)
{
    double minArray=array[0];
    for(int i =1;i<array.Length;i++)
    {
        if (minArray>array[i])
        minArray = array[i];
    
    }
    return minArray;
}

Console.Write("Введите колво элементов массива:");
int n =Convert.ToInt32 (Console.ReadLine());
double[]array = new double [n];
InputArray(array);
Console.WriteLine($"Исходный массив:[{string.Join(",",array)}]");
Console.WriteLine($"Разница между макс и мин такая:{SearchMaxToArray(array)-SearchMinToArray(array)}");