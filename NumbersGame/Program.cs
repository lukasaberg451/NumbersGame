namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            bool isGuessCorrect = false;
            int randomNumber = new Random().Next(1, 21);

            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");

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
        }
    }
}
