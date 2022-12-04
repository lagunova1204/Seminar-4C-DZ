Console.WriteLine("Напишите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = n; i > 0; i = i/10)
{
    n = i%10;
    sum = sum + n;
}
Console.WriteLine($"{sum}");
