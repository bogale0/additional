Console.WriteLine("Введите целое число: ");
int n;
if (int.TryParse(Console.ReadLine(), out n))
{
    n -= 123;
    Console.WriteLine($"Результат: {(n > 0 ? 3 * n : -n)}");
}
else
{
    Console.WriteLine("Неправильный формат ввода!");
}