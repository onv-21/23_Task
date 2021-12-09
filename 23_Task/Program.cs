
static void Factorial()
{
    int result = 1;
    for (int i = 1; i <= 10; i++)
    {
        result *= i;
    }
    Thread.Sleep(5000);
    Console.WriteLine($"Факториал равен {result}");
}

static async void FactorialAsync()
{
    Console.WriteLine("Начало метода FactorialAsync"); 
    await Task.Run(() => Factorial());                
    Console.WriteLine("Конец метода FactorialAsync");
}



    FactorialAsync();

    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Квадрат числа равен {n * n}");

    Console.Read();
