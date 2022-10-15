// See https://aka.ms/new-console-template for more informationCon
Console.Clear();
int [] array = {1,2,3,4,5};
int [] b = new int [array.Length];
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"[{string.Join(",", b)}]");
for (int i=0; i<array.Length;i++)
b[i]=array [i];

b[0]=-10;
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"[{string.Join(",", b)}]");