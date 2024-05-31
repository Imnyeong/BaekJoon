using System;

class Program
{
    static void Main(String[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(input[0]);
        int B = Convert.ToInt32(input[1]);

        Console.WriteLine(A + B);
        Console.WriteLine(A - B);
        Console.WriteLine(A * B);
        Console.WriteLine(A / B);
        Console.WriteLine(A % B);
    }
}