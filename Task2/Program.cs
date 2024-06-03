﻿int Ack (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return (Ack (m - 1, 1));
    }
    else
    {
        return Ack (m - 1, Ack (m, n - 1));
    }
}
int m = 3;
int n = 4;
int result = Ack (m, n);
Console.WriteLine ($"Ack({m}, {n}) = {result}");