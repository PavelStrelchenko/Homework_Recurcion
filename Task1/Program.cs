void NumbersSeries (int m, int n)
{
     if (m < n)
     {
        if (m == n)
        {
        return ;
        }
        Console.Write(m + " ");
        NumbersSeries (m + 1, n);
     }
     else 
     {
        if(m == n)
        {
            return;
        }
        NumbersSeries (m - 1, n);
        Console.Write(m + " ");
     }
       

}
NumbersSeries (1, 10);