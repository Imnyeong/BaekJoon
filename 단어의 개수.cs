using System;
using System.Text;

class Program
{
    static void Main(String[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int count = 0;

        foreach(string each in input)
        {
            if (!each.Equals(string.Empty))
                count++;
        }

        Console.WriteLine(count.ToString());
    }
}