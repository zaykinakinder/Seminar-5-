// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите колисчество учеников:");
int n = Convert.ToInt32(Console.ReadLine());
int[]array =new int[n];

for (int i=0; i<array.Length; i++)
array [i]= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите свой:");
int rost = Convert.ToInt32(Console.ReadLine());
int count =1;

for (int i = 0; i<array.Length; i++)
{
    if (array[i]>rost)
    count++;
    }

Console.WriteLine(count);


















Console.Clear();


void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10);
}


int PositiveSum(int[] array)
{
int sumPos = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
sumPos += array[i];
}

return sumPos;
}

int NegativeSum(int[] array)
{
int sumNeg = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] < 0)
sumNeg += array[i];
}

return sumNeg;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма положительных равна {PositiveSum(array)}");
Console.WriteLine($"Сумма отрицательных равна {NegativeSum(array)}");