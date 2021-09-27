using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            Random random = new Random();
            P.ConsoleSettings();
            Console.WriteLine(String.Format("{0," + (Console.WindowWidth - 23) + "}", "Välkommen till Numbers Game"));

            bool wrongInput = true;
            bool gameMenu2 = true;
            bool gameMenu3;
            string playAgain;
            int userGuess;
            int guessCount = 0;

            Console.WriteLine();

            while (gameMenu2)
            {
                gameMenu3 = true;

                P.DiffMenu();
                Console.WriteLine();
                Console.Write("Menyval: ");
                string difficultyMenu = Console.ReadLine();

                switch (difficultyMenu)
                {

                    case "1":

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Svårighetsgrad [Easy] Tal mellan 1-10");
                        Console.WriteLine();
                        Console.WriteLine("Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

                        int randomNumber = random.Next(1, 11);

                        while (gameMenu3)
                        {
                            guessCount++;

                            if (!int.TryParse(Console.ReadLine(), out userGuess))
                            {
                                Console.WriteLine("Du måste skriva en Siffra");
                                guessCount--;
                            }

                            else if (userGuess == randomNumber)
                            {
                                Console.WriteLine("Woho! du gissade rätt!");
                                Console.WriteLine();
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)

                                {

                                    playAgain = Console.ReadLine();
                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;

                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }
                            }

                            else if (guessCount == 5)
                            {
                                Console.WriteLine("Du har gissat för många gånger, du förlorar");
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)
                                {
                                    playAgain = Console.ReadLine();

                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;
                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }

                            }
                            else if (userGuess > randomNumber)
                            {

                                Console.WriteLine("Du gissade för högt!");

                            }
                            else if (userGuess < randomNumber)
                            {
                                Console.WriteLine("Du gissade för lågt!");
                            }
                        }

                        break;
                    case "2":

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Svårighetsgrad [Normal] Tal mellan 1-20");
                        Console.WriteLine();
                        Console.WriteLine("Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

                        randomNumber = random.Next(1, 21);

                        while (gameMenu3)
                        {
                            guessCount++;

                            if (!int.TryParse(Console.ReadLine(), out userGuess))
                            {
                                Console.WriteLine("Du måste skriva en Siffra");
                                guessCount--;
                            }

                            else if (userGuess == randomNumber)
                            {
                                Console.WriteLine("Woho! du gissade rätt!");
                                Console.WriteLine();
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)

                                {

                                    playAgain = Console.ReadLine();
                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;

                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }
                            }

                            else if (guessCount == 5)
                            {
                                Console.WriteLine("Du har gissat för många gånger, du förlorar");
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)
                                {
                                    playAgain = Console.ReadLine();

                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;
                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }

                            }
                            else if (userGuess > randomNumber)
                            {

                                Console.WriteLine("Du gissade för högt!");

                            }
                            else if (userGuess < randomNumber)
                            {
                                Console.WriteLine("Du gissade för lågt!");
                            }
                        }

                        Console.WriteLine();

                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.WriteLine("Svårighetsgrad [Hard] Tal mellan 1-50");
                        Console.WriteLine();
                        Console.WriteLine("Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

                        randomNumber = random.Next(1, 51);

                        while (gameMenu3)
                        {
                            guessCount++;

                            if (!int.TryParse(Console.ReadLine(), out userGuess))
                            {
                                Console.WriteLine("Du måste skriva en Siffra");
                                guessCount--;
                            }

                            else if (userGuess == randomNumber)
                            {
                                Console.WriteLine("Woho! du gissade rätt!");
                                Console.WriteLine();
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)

                                {

                                    playAgain = Console.ReadLine();
                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;

                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }
                            }

                            else if (guessCount == 5)
                            {
                                Console.WriteLine("Du har gissat för många gånger, du förlorar");
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)
                                {
                                    playAgain = Console.ReadLine();

                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;
                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }

                            }
                            else if (userGuess > randomNumber)
                            {

                                Console.WriteLine("Du gissade för högt!");

                            }
                            else if (userGuess < randomNumber)
                            {
                                Console.WriteLine("Du gissade för lågt!");
                            }
                        }

                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Svårighetsgrad [Impossible] Tal mellan 1-100");
                        Console.WriteLine();
                        Console.WriteLine("Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
                        randomNumber = random.Next(1, 101);

                        while (gameMenu3)
                        {
                            guessCount++;

                            if (!int.TryParse(Console.ReadLine(), out userGuess))
                            {
                                Console.WriteLine("Du måste skriva en Siffra");
                                guessCount--;
                            }

                            else if (userGuess == randomNumber)
                            {
                                Console.WriteLine("Woho! du gissade rätt!");
                                Console.WriteLine();
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)

                                {

                                    playAgain = Console.ReadLine();
                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;

                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }
                            }

                            else if (guessCount == 5)
                            {
                                Console.WriteLine("Du har gissat för många gånger, du förlorar");
                                Console.WriteLine("Vill du spela igen? Ja/Nej");

                                while (wrongInput)
                                {
                                    playAgain = Console.ReadLine();

                                    if (playAgain.ToUpper() == "JA")
                                    {
                                        gameMenu3 = false;
                                        guessCount = 0;
                                        Console.Clear();

                                        break;
                                    }
                                    else if (playAgain.ToUpper() == "NEJ")
                                    {
                                        wrongInput = false;
                                        gameMenu3 = false;
                                        gameMenu2 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vänligen svara Ja/Nej");

                                    }
                                }

                            }
                            else if (userGuess > randomNumber)
                            {

                                Console.WriteLine("Du gissade för högt!");

                            }
                            else if (userGuess < randomNumber)
                            {
                                Console.WriteLine("Du gissade för lågt!");
                            }
                        }
                        break;
                }
                Console.Clear();

            }
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + (Console.WindowWidth - 23) + "}", "Tack för att du spelade!"));
        }

        public void ConsoleSettings()
        {
            Console.WindowHeight = 25;
            Console.WindowWidth = 70;
        }

        public void DiffMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[1] Easy = Gissa ett tal mellan 1 och 10, du får 5 gissningar");
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("[2] Normal = Gissa ett tal mellan 1 och 20, du får 5 gissningar");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("[3] Hard = Gissa ett tal mellan 1 och 50, du får 5 gissningar");
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[4] Impossible = Gissa ett tal mellan 1 och 100, du får 5 gissnigar");
            Console.ResetColor();
        }
    }
}