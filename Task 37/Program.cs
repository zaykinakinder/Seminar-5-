void InputArray (int[] array)
{
    for (int i =0; i<array.Length; i++)
    array[i] = new Random().Next(1,11);

}
void ReleaseArray (int [] array)
{

    for (int i =0; i<array.Length/2 + array.Length % 2 ; i ++)
       Console.Write (array [i]* array [array.length-i-1]);
    
}

int [] array = new int [123];
InputArray(array);
Console.WriteLine("Введите число");
Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(ReleaseArray(array));

