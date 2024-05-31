using System;

class Program
{
    static void Main(String[] args)
    {
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(A * (B % 10));
        Console.WriteLine(A * ((B % 100 - B % 10) / 10));
        Console.WriteLine(A * (B / 100));
        Console.WriteLine(A * B);
    }
}