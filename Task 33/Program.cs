// See https://aka.ms/new-console-template for more information
Console.Clear();


void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10);
}


string ReleaseArray(int[] array, int x)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] == x)
return "yes";
}
return "no";
}


Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, x));
