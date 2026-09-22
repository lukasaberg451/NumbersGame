namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wantsToExit;

            // Outer Do-While to keep the program running until number 9 is choosen.
            do
            {
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");
                int attempts = 0;
                bool isGuessCorrect = false;
                int randomNumber = new Random().Next(1, 21);

                // Inner Do-While to get the input from the user and then validate it via a method.
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out int userSelection))
                    {
                        Console.WriteLine("Fel inmatning. Du måste enge ett heltal mellan 1 och 20.");
                        continue;
                    }

                    isGuessCorrect = Utilities.CheckGuess(randomNumber, userSelection);

                    attempts++;
                }
                while (attempts != 5 && isGuessCorrect != true);

                if (attempts == 5 && isGuessCorrect == false)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök");
                }

                Console.WriteLine("Vill du fortsätta spela? Skriv 1 för att fortsätta och 9 för att avsluta.");

                if (!int.TryParse(Console.ReadLine(), out wantsToExit))
                {
                    Console.WriteLine("Fel inmatning. Skriv 1 för att fortsätta och 9 för att avsluta");
                    continue;
                }
            } while (wantsToExit != 9);

            Console.WriteLine("Tack för att du spelade!");
        }
    }
}
