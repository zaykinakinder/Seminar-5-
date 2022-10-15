// See https://aka.ms/new-console-template for more information
bool isPrime (int n)
{
for (int i =2 ;i<=n ;i++)

{
    if (n % i==0)
    return false;
}
return true;
}
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int SumNumbers = 0;
if (isPrime(x))
    SumNumbers +=x;
if (isPrime(y))
    SumNumbers +=y;
if (isPrime(z))
    SumNumbers +=z;

if (isPrime(SumNumbers))
  Console.WriteLine ($"{SumNumbers} {isPrime(SumNumbers)}");

