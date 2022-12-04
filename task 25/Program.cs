Console.WriteLine("Введите число, которое нужно ввести в степень");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 0; i < B; i++)
{
    result = result * A;
    
}

    Console.WriteLine($"{result}");

