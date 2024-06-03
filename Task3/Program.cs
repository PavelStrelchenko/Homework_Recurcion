void PrintNumbers (int [] array, int i)
{
    if (i < 0) 
    {
        return;
    }
    Console.Write($"{array[i]} ");
    PrintNumbers (array, i - 1);
    
}
int [] numbers = new int [] {1, 2, 3, 4, 5};
int i = numbers.Length - 1;
PrintNumbers (numbers, i);

