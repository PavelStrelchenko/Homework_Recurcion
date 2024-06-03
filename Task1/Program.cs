void NumbersSeries (int m, int n)
{
    if (m < n)
    {
        if (m > n)
        {
            return;
        }
       
    Console.Write(m + " ");
    NumbersSeries (m + 1, n);
        
    }
    if (m > n)
    {
        Console.WriteLine("Некорретный ввод (число m должно быть меньшим)");
    }
}
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
NumbersSeries (m, n);