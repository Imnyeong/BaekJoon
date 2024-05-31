using System;

class Program
{
    static void Main(String[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((input % 4 == 0 && (input % 100 != 0 || input % 400 == 0)) ? "1" : "0");
        //if(input % 4 == 0 && input % 100 != 0)
    }
}