using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerRoll;
        int computerRoll;

        do
        {
            // Roll a 6-sided die for player and computer (1 to 6)
            playerRoll = random.Next(1, 7);
            computerRoll = random.Next(1, 7);

            Console.WriteLine($"You rolled: {playerRoll}");
            Console.WriteLine($"Computer rolled: {computerRoll}");

            if (playerRoll > computerRoll)
            {
                Console.WriteLine("Result: You win!");
            }
            else if (computerRoll > playerRoll)
            {
                Console.WriteLine("Result: Computer wins!");
            }
            else
            {
                Console.WriteLine("Result: It's a tie! Re-rolling...\n");
            }

        } while (playerRoll == computerRoll);
    }
}
