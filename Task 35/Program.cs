// See https://aka.ms/new-console-template for more information
void InputArray (int[] array)
{
    for (int i =0; i<array.Length; i++)
    array[i] = new Random().Next(-100, 200);

}
int ReleaseArray (int [] array)
{
    int count = 0;
    for (int i =0; i<array.Length; i ++)
    {
        if (array[i]>=10 && array[i]<=99)
        count ++;
    }
    return count;
}

int [] array = new int [123];
InputArray(array);
Console.WriteLine("["+ string.Join(",", array)+"]");
Console.WriteLine(ReleaseArray(array));
