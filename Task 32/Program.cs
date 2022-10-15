// See https://aka.ms/new-console-template for more information
void InputArray (int[] array)
{
    for (int i =0; i<array.Length; i++)
    array[i] = new Random().Next(-9, 10);

}
void ReplaceArray (int []array)
{

    for (int i =0 ; i< array.Length; i++)
    array [i]= array[i]* (-1);
}

Console.Write("Введите колво элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
InputArray (array);
Console.WriteLine ("[" + string.Join(",", array)+ "]");
ReplaceArray(array);
Console.WriteLine ("[" + string.Join(",", array)+ "]");

