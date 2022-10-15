using System;

namespace FibSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Very basic method, but works..I think

                // DECLARE VARIABLES //
                long num1 = 0, num2 = 1, num3 = 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"==== FIBBONACCI SEQUENCE ====");
                //ASK FOR USER SEQUENCE NUMBER INPUT
                Console.Write($"Please enter a number limit: ");
                //STORE INPUT INTO AN INTEGER VARIABLE
                long userNumber = long.Parse(Console.ReadLine());

                //FOR LOOP , INDEX FROM 1 LESS THAN OR GREATER THAN USERS NUMBER INPUTTED
                for (int i = 1; i <= userNumber; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{num3} ");
                    num3 = num1 + num2;
                    num1 = num2;
                    num2 = num3;
                }
            }
               catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error " + error.Message);
            }
            Console.ReadKey();
        }
    }
}
