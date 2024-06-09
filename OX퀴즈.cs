using System;

class Program
{
    static void Main(String[] args)
    {
        int lineCount = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < lineCount; i++)
        {
            string input = Console.ReadLine();

            int count = 0;
            int score = 0;

            for(int j = 0; j < input.Length; j++)
            {
                if(input[j] == 'O')
                {
                    count++;
                    score += count;
                }
                else
                {
                    count = 0;
                }
            }

            Console.WriteLine(score.ToString());
        }
    }
}