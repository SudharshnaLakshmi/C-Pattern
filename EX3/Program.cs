using System;
public class EX3
{
    public static void Main()
    {
        int no_row, c = 1, k, i, j;
        Console.Write("Input number of rows: ");
        no_row = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nThe Pascal's triangle:\n");
        for (i = 0; i < no_row; i++)
        {
            for (k = 1; k <= no_row - i; k++)
                Console.Write("  ");
            for (j = 0; j <= i; j++)
            {
                if (j == 0 || i == 0)
                    c = 1;
                else
                    c = c * (i - j + 1) / j;
                Console.Write("{0}   ", c);
            }
            Console.Write("\n");
        }
    }
}
