// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое значение:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье значение:");
int  p = Convert.ToInt32(Console.ReadLine());
{
if (n + m >p && m+p>n&& p+n>m)
Console.WriteLine("Good");
else Console.WriteLine("Immpossible");
}
