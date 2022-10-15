// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a number");
int n = Convert.ToInt32(Console.ReadLine());
string? s =string.Empty;

while (n>0)
{
    int x = n%2;
    s=s+ Convert.ToString(x);
n=n/2;

}
Console.WriteLine(s);
