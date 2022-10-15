// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int n =Convert.ToInt32(Console.ReadLine());
int a0=0, a1=1, x;

for (int i=0; i < n; i++);

{
    

    x = a0+a1;
    a0=a1;
    a1=x;


}

 Console.WriteLine (a0+" ");

