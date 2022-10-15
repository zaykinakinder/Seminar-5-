void InputArray (int[] array)
{
    for (int i =0; i<array.Length; i++)
    array[i] = new Random().Next(-10,11);

}

int [] ReleaseArray (int[] array)
{
    
    for (int i =0; i< array.Length/2; i++)
    {
        int temp = array [i];
        array [i]= array[array.Length -i-1];
        array [array.Length-i-1]=temp;
    }
    return array;
}

{
    Console. Write ("введите кол-во элементов массива:");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [n];
    InputArray (array);
    Console.WriteLine($"Исходный массив:[{String.Join(",", array)}]");
    Console.WriteLine($"конечный массив:[{String.Join(",", ReleaseArray (array))}]");
}