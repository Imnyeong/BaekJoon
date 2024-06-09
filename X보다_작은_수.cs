using System;
using System.Text;

class Program
{
    static void Main(String[] args)
    {
        string[] input_1 = Console.ReadLine().Split(' ');
        int X = Convert.ToInt32(input_1[1]);

        string[] input_2 = Console.ReadLine().Split(' ');

        StringBuilder stringBuilder = new StringBuilder();

        foreach(string strValue in input_2)
        {
            if(Convert.ToInt32(strValue) < X)
            {
                stringBuilder.Append(strValue + " ");
            }
        }

        Console.WriteLine(stringBuilder.ToString());
    }
}