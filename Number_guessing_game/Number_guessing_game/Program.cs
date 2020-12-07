using System;
using UserInfo;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Number_guessing_game
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            OpeningScreenWithLogoTheeme();
            MainMenuScreen();
            QuitGameScreen();

        }
        static void OpeningScreenWithLogoTheeme()
        {
            DisplayGameLogoTheme();
            ContinuePrompt();   
        
        }
        static void MainMenuScreen()
        {
            List<string> ResponseOnFireList = new List<string>();
            List<string> ResponseHotList = new List<string>();
            List<string> ResponseVeryHotList = new List<string>();
            List<string> ResponseWarmList = new List<string>();
            List<string> ResponseGettingColdList = new List<string>();
            List<string> ResponseColdList = new List<string>();
            List<string> ResponseVeryColdList = new List<string>();
            List<string> ResponseYourFrozenList = new List<string>();

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t||******************************************||");
                Console.WriteLine("\t||       Numbers Guessing Game Menu         ||");   
                Console.WriteLine("\t||******************************************||");
                Console.WriteLine("\t||                                          ||");
                Console.WriteLine("\t|| (A): Guess a Number Between: 1 - 10      ||");
                Console.WriteLine("\t||                                          ||");
                Console.WriteLine("\t|| (B): Guess a Number Between: 1 - 100     ||");
                Console.WriteLine("\t||                                          ||");
                Console.WriteLine("\t|| (C): Guess a Number Between  1 - 1000    ||");
                Console.WriteLine("\t||                                          ||");
                Console.WriteLine("\t|| (D): Read Game Rules                     ||");
                Console.WriteLine("\t||                                          ||");
                Console.WriteLine("\t|| (E): Quit Game                           ||");
                Console.WriteLine("\t||                                          ||");
                Console.WriteLine("\t**********************************************");

                bool validResponse;
                string MenuChoice;

                do
                {
                    validResponse = false;

                    Console.Write("\n\tPlease choose a number: ");
                    MenuChoice = Console.ReadLine().ToUpper();
                    if (MenuChoice == "A" || MenuChoice == "B" || MenuChoice == "C" || MenuChoice == "D" || MenuChoice == "E")
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.CursorVisible = false;
                        Console.WriteLine("\n\tPlease enter a valid Menu Choice");
                        ContinuePrompt();
                    }
                } while (!validResponse);

                switch (MenuChoice)
                {
                    case "A":
                        NumbersGameLevel10(ResponseOnFireList, ResponseHotList, ResponseVeryHotList, ResponseWarmList, ResponseGettingColdList,
                   ResponseColdList, ResponseVeryColdList, ResponseYourFrozenList);
                        break;
                    case "B":
                        NumbersGameLevel100(ResponseOnFireList, ResponseHotList, ResponseVeryHotList, ResponseWarmList, ResponseGettingColdList,
                    ResponseColdList, ResponseVeryColdList, ResponseYourFrozenList);
                        break;
                    case "C":
                        NumbersGameLevel1000(ResponseOnFireList, ResponseHotList, ResponseVeryHotList, ResponseWarmList, ResponseGettingColdList,
                    ResponseColdList, ResponseVeryColdList, ResponseYourFrozenList);
                        break;
                    case "E":
                        QuitGameScreen();
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        private static void QuitGameScreen()
        {
            Console.WriteLine("\t||********************************||");
            Console.WriteLine("\t||      Thanks for Playing!       ||");
            Console.WriteLine("\t||                                ||");
            Console.WriteLine("\t|| Please hit Enter to quit or    ||" +
            	                "\t||                                ||" +
                              "\t|| Hit esc to return to Game Menu ||");
            Console.WriteLine("\t||                                ||");
            Console.WriteLine("\t************************************");

            var input = Console.ReadKey().Key;
            switch (input)
            {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Escape:
                    MainMenuScreen();
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Displaies the game logo theme.
        /// </summary>
        static void DisplayGameLogoTheme()
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("\t||**********************************************************||");
            Console.WriteLine("\t||    __     _   _    __        _______ _____ ___________   ||");
            Console.WriteLine("\t||   |  \\   | | | |  |  \\      /   __  |  ___|  _  |  ___|  ||");
            Console.WriteLine("\t||   | | \\  | | | |  | | \\    / | |_/ /| |___| |_| | |___   ||");
            Console.WriteLine("\t||   | |\\ \\ | | | |  | |\\ \\  / /|  _ | |  ___|    _|___  |  ||");
            Console.WriteLine("\t||   | | \\ \\| | | |  | | \\ \\/ / | | \\ \\| |   | |\\ \\    | |  ||");
            Console.WriteLine("\t||   | |  \\ | | | |__| |  \\  /  | |__| | |___| | \\ \\___| |  ||");
            Console.WriteLine("\t||   |_|   \\__| |______|   \\/   |______|_____|_|  \\_\\____|  ||");
            Console.WriteLine("\t||    _____ _   _ _________ _______   _ _____               ||");
            Console.WriteLine("\t||   |  _  | | | |  __|  __|_   _| \\ | |  _  |              ||");
            Console.WriteLine("\t||   | |_| | | | | |__| |__  | | |  \\| | |_| |              ||");
            Console.WriteLine("\t||   |____ | | | |__  |__  | | | | \\ \\ |____ |              ||");
            Console.WriteLine("\t||    ___| | |_| |__| |__| |_| |_| |\\  |___| |              ||");
            Console.WriteLine("\t||   |_____|_____|____|____|_____|_| \\_|_____|              ||");
            Console.WriteLine("\t||    _____  ___  _    _ ____                               ||");
            Console.WriteLine("\t||   |  _  |/ _ \\| \\  / |  __|                              ||");
            Console.WriteLine("\t||   | |_| | |_| |  \\/  | |__                               ||");
            Console.WriteLine("\t||   |____ |  _  | |\\/| |  __|                              ||");
            Console.WriteLine("\t||    ___| | | | | |  | | |__                               ||");
            Console.WriteLine("\t||   |_____|_| |_| |  | |____|                              ||");
            Console.WriteLine("\t||                                                          ||");
            Console.WriteLine("\t**************************************************************");
        }
        #region Numbers Game Level 100
        /// <summary>
        /// Numberses the game level100
        /// </summary>
        /// <param name="ResponseOnFireList">Response on fire list.</param>
        /// <param name="ResponseHotList">Response hot list.</param>
        /// <param name="ResponseVeryHotList">Response very hot list.</param>
        /// <param name="ResponseWarmList">Response warm list.</param>
        /// <param name="ResponseGettingColdList">Response getting cold list.</param>
        /// <param name="ResponseColdList">Response cold list.</param>
        /// <param name="ResponseVeryColdList">Response very cold list.</param>
        /// <param name="ResponseYourFrozenList">Response your frozen list.</param>
        static void NumbersGameLevel100(List<string> ResponseOnFireList, List<string> ResponseHotList,
            List<string> ResponseVeryHotList, List<string> ResponseWarmList, List<string> ResponseGettingColdList,
            List<string> ResponseColdList, List<string> ResponseVeryColdList, List<string> ResponseYourFrozenList)
        {
            Random random = new Random();

            int usersGuess = 0;
            int answer = random.Next(1, 100);
            int a = 1;
            int[] usersGuessArray = new int[20];
            int output = 0;

            do
            {
                GetRandomResponseStrings(ResponseOnFireList, ResponseHotList, ResponseVeryHotList, ResponseWarmList, ResponseGettingColdList,
                    ResponseColdList, ResponseVeryColdList, ResponseYourFrozenList, out string RandomOnFireString, out string RandomHotString,
                    out string RandomVeryHotString, out string RandomWarmString, out string RandomGettingColdString, out string RandomColdString,
                    out string RandomVeryColdString, out string RandomYourFrozenString);

                usersGuessArray[a] = usersGuess;

                Console.Clear();
                Console.WriteLine("\n\t||******************************************||");
                Console.WriteLine("\t||       Numbers Guessing Game 1 - 100      ||");
                Console.WriteLine("\t||******************************************||");
                Console.WriteLine("\t||                                            ");
                Console.WriteLine($"\t|| Turn: [{a}]");
                Console.WriteLine("\t||                                            ");
                Console.Write($"\t|| Previous guess: ");

                foreach (int item in usersGuessArray)
                {
                    if (item != 0)
                    {
                        Console.Write($"{item},");

                    }
                }
                Console.WriteLine("\n\t||                                            ");
                a++;
                usersGuess = NumberGuess100Input();
                Console.WriteLine("\t||");
                output = MathOperationForGuessNumbersOutpot(usersGuess, answer);

                if (output <= 25 && output >= 1)
                {
                    if (output < 10)
                    {
                        Console.WriteLine($"\t|| {RandomOnFireString}");
                    }
                    else if (output > 10)
                    {
                        Console.WriteLine($"\t|| {RandomVeryHotString}");
                    }
                    else { continue; }
                }
                else if (output > 25 && output <= 50)
                {
                    if (output <= 35)
                    {
                        Console.WriteLine($"\t|| {RandomHotString}");
                    }
                    else if (output > 35)
                    {
                        Console.WriteLine($"\t|| {RandomWarmString}");
                    }
                    else { continue; }
                }
                else if (output > 50 && output <= 75)
                {
                    if (output <= 65)
                    {
                        Console.WriteLine($"\t|| {RandomGettingColdString}");
                    }
                    else if (output > 65)
                    {
                        Console.WriteLine($"\t|| {RandomColdString}");
                    }
                    else { continue; }
                }
                else if (output > 75)
                {
                    if (output <= 90)
                    {
                        Console.WriteLine($"\t|| {RandomVeryColdString}");
                    }
                    else if (output > 90)
                    {
                        Console.WriteLine($"\t|| {RandomYourFrozenString}");
                    }
                    else { continue; }
                }
                else if (usersGuess == answer)
                {
                    Console.WriteLine("\t|| Congratulations you Won!!");
                }
                else if (a > 20)
                {
                    Console.WriteLine("\t|| You ran out of turns, Sorry.");
                }
                else {  }

                Console.WriteLine("\t||");
                Console.WriteLine("\t||******************************************||");
                Console.WriteLine($"\n\tAnswer: {answer}, usersQuess: {usersGuess} output: {output}");
                Console.WriteLine("\n\t______________________________");

                ContinuePrompt();

            } while (usersGuess != answer && a < 20);

            MenuPrompt("Main");
        }

        #endregion
        #region Numbers Game Level 10
        /// <summary>
        /// Numberses the game level 10.
        /// </summary>
        /// <param name="ResponseOnFireList">Response on fire list.</param>
        /// <param name="ResponseHotList">Response hot list.</param>
        /// <param name="ResponseVeryHotList">Response very hot list.</param>
        /// <param name="ResponseWarmList">Response warm list.</param>
        /// <param name="ResponseGettingColdList">Response getting cold list.</param>
        /// <param name="ResponseColdList">Response cold list.</param>
        /// <param name="ResponseVeryColdList">Response very cold list.</param>
        /// <param name="ResponseYourFrozenList">Response your frozen list.</param>
        static void NumbersGameLevel10(List<string> ResponseOnFireList, List<string> ResponseHotList,
            List<string> ResponseVeryHotList, List<string> ResponseWarmList, List<string> ResponseGettingColdList,
            List<string> ResponseColdList, List<string> ResponseVeryColdList, List<string> ResponseYourFrozenList)
        {
            Random random = new Random();

            int usersGuess = 0;
            int answer = random.Next(1, 10);
            int a = 1;
            int[] usersGuessArray = new int[5];
            int output = 0;
           
            do
            {
                GetRandomResponseStrings(ResponseOnFireList, ResponseHotList, ResponseVeryHotList, ResponseWarmList, ResponseGettingColdList,
                    ResponseColdList, ResponseVeryColdList, ResponseYourFrozenList, out string RandomOnFireString, out string RandomHotString,
                    out string RandomVeryHotString, out string RandomWarmString, out string RandomGettingColdString, out string RandomColdString,
                    out string RandomVeryColdString, out string RandomYourFrozenString);

                usersGuessArray[a] = usersGuess;

                Console.Clear();
                Console.WriteLine("\n\t||******************************************||");
                Console.WriteLine  ("\t||       Numbers Guessing Game 1 - 10       ||");
                Console.WriteLine  ("\t||******************************************||");      
                Console.WriteLine  ("\t||                                            ");
                Console.WriteLine ($"\t|| Turn: [{a}]");
                Console.WriteLine  ("\t||                                            ");
                Console.Write     ($"\t|| Previous guess: ");

                foreach (int item in usersGuessArray)
                {
                    if (item != 0)
                    {
                        Console.Write($"{item},");
                       
                    }
                }
                Console.WriteLine("\n\t||                                            ");
                a++;
                usersGuess = NumberGuess100Input();
                Console.WriteLine("\t||");
                output = MathOperationForGuessNumbersOutpot(usersGuess, answer);

                if (output <= 2)
                {
                    if (output == 1)
                    {
                        Console.WriteLine($"\t|| {RandomOnFireString}");
                    }
                    else if (output == 2)
                    {
                        Console.WriteLine($"\t|| {RandomVeryHotString}");
                    }
                    else { continue; }
                }
                else if (output >= 3 )
                {
                    if (output == 3)
                    {
                        Console.WriteLine($"\t|| {RandomHotString}");
                    }
                    else if (output == 4)
                    {
                        Console.WriteLine($"\t|| {RandomWarmString}");
                    }
                    else { continue; }
                }
                else if (output >= 5)
                {
                    if (output >= 5)
                    {
                        Console.WriteLine($"\t|| {RandomGettingColdString}");
                    }
                    else if (output == 7)
                    {
                        Console.WriteLine($"\t|| {RandomColdString}");
                    }
                    else { continue; }
                }
                else if(output >= 8)
                {
                    if (output == 8)
                    {
                        Console.WriteLine($"\t|| {RandomVeryColdString}");
                    }
                    else if (output > 9)
                    {
                        Console.WriteLine($"\t|| {RandomYourFrozenString}");
                    }
                    else { continue; }
                }
                else if (usersGuess == answer)
                {
                    Console.WriteLine("\t|| Congratulations you Won!!");
                }
                else if (a > 5)
                {
                    Console.WriteLine("\t|| You ran out of turns, Sorry.");
                }
                else { continue; }

                Console.WriteLine("\t||");
                Console.WriteLine("\t||******************************************||");
                Console.WriteLine($"\n\tAnswer: {answer}, usersQuess: {usersGuess} output: {output}");
                Console.WriteLine("\n\t______________________________");

                ContinuePrompt();

            } while (usersGuess != answer && a < 6);

            MenuPrompt("Main");
        }

        #endregion
        #region Numbers Game Level 1000
        /// <summary>
        /// Numberses the game level1000.
        /// </summary>
        /// <param name="ResponseOnFireList">Response on fire list.</param>
        /// <param name="ResponseHotList">Response hot list.</param>
        /// <param name="ResponseVeryHotList">Response very hot list.</param>
        /// <param name="ResponseWarmList">Response warm list.</param>
        /// <param name="ResponseGettingColdList">Response getting cold list.</param>
        /// <param name="ResponseColdList">Response cold list.</param>
        /// <param name="ResponseVeryColdList">Response very cold list.</param>
        /// <param name="ResponseYourFrozenList">Response your frozen list.</param>
        static void NumbersGameLevel1000(List<string> ResponseOnFireList, List<string> ResponseHotList,
            List<string> ResponseVeryHotList, List<string> ResponseWarmList, List<string> ResponseGettingColdList,
            List<string> ResponseColdList, List<string> ResponseVeryColdList, List<string> ResponseYourFrozenList)
        {

            Random random = new Random();

            int usersGuess = 0;
            int answer = random.Next(1, 1000);
            int a = 1;
            int[] usersGuessArray = new int[50];
            int output = 0;

            do
            {
                GetRandomResponseStrings(ResponseOnFireList, ResponseHotList, ResponseVeryHotList, ResponseWarmList, ResponseGettingColdList,
                    ResponseColdList, ResponseVeryColdList, ResponseYourFrozenList, out string RandomOnFireString, out string RandomHotString,
                    out string RandomVeryHotString, out string RandomWarmString, out string RandomGettingColdString, out string RandomColdString,
                    out string RandomVeryColdString, out string RandomYourFrozenString);
                 usersGuessArray[a] = usersGuess;

                Console.Clear();
                Console.WriteLine("\n\t||******************************************||");
                Console.WriteLine  ("\t||      Numbers Guessing Game 1 - 1000      ||");
                Console.WriteLine  ("\t||******************************************||");      
                Console.WriteLine  ("\t||                                            ");
                Console.WriteLine ($"\t|| Turn: [{a}]");
                Console.WriteLine  ("\t||                                            ");
                Console.Write     ($"\t|| Previous guess: ");

                foreach (int item in usersGuessArray)
                {
                    if (item != 0)
                    {
                        Console.Write($"{item},");
                       
                    }
                }
                Console.WriteLine("\n\t||                                            ");
                a++;
                usersGuess = NumberGuess1000Input();
                Console.WriteLine("\t||");
                output = MathOperationForGuessNumbersOutpot(usersGuess, answer);

                if (output <= 250 && output >= 1)
                {
                    if (output < 100)
                    {
                        Console.WriteLine($"\t|| {RandomOnFireString}");
                    }
                    else if (output > 100)
                    {
                        Console.WriteLine($"\t|| {RandomVeryHotString}");
                    }
                    else { continue; }
                }
                else if (output > 250 && output <= 500)
                {
                    if (output <= 350)
                    {
                        Console.WriteLine($"\t|| {RandomHotString}");
                    }
                    else if (output > 350)
                    {
                        Console.WriteLine($"\t|| {RandomWarmString}");
                    }
                    else { continue; }
                }
                else if (output > 500 && output <= 750)
                {
                    if (output <= 650)
                    {
                        Console.WriteLine($"\t|| {RandomGettingColdString}");
                    }
                    else if (output > 650)
                    {
                        Console.WriteLine($"\t|| {RandomColdString}");
                    }
                    else { continue; }
                }
                else if(output > 750)
                {
                    if (output <= 900)
                    {
                        Console.WriteLine($"\t|| {RandomVeryColdString}");
                    }
                    else if (output > 900)
                    {
                        Console.WriteLine($"\t|| {RandomYourFrozenString}");
                    }
                    else { continue; }
                }
                else if (usersGuess == answer)
                {
                    Console.WriteLine("\t|| Congratulations you Won!!");
                }
                else if (a > 50)
                {
                    Console.WriteLine("\t|| You ran out of turns, Sorry.");
                }
                else { continue; }

                Console.WriteLine("\t||");
                Console.WriteLine("\t||******************************************||");
                Console.WriteLine($"\n\tAnswer: {answer}, usersQuess: {usersGuess} output: {output}");
                Console.WriteLine("\n\t______________________________");

                ContinuePrompt();

            } while (usersGuess != answer && a < 50);

            MenuPrompt("Main");
        }

        #endregion
        #region Get Random Response String
        /// <summary>
        /// Gets the random response strings.
        /// </summary>
        /// <param name="ResponseOnFireList">Response on fire list.</param>
        /// <param name="ResponseHotList">Response hot list.</param>
        /// <param name="ResponseVeryHotList">Response very hot list.</param>
        /// <param name="ResponseWarmList">Response warm list.</param>
        /// <param name="ResponseGettingColdList">Response getting cold list.</param>
        /// <param name="ResponseColdList">Response cold list.</param>
        /// <param name="ResponseVeryColdList">Response very cold list.</param>
        /// <param name="ResponseYourFrozenList">Response your frozen list.</param>
        /// <param name="RandomOnFireString">Random on fire string.</param>
        /// <param name="RandomHotString">Random hot string.</param>
        /// <param name="RandomVeryHotString">Random very hot string.</param>
        /// <param name="RandomWarmString">Random warm string.</param>
        /// <param name="RandomGettingColdString">Random getting cold string.</param>
        /// <param name="RandomColdString">Random cold string.</param>
        /// <param name="RandomVeryColdString">Random very cold string.</param>
        /// <param name="RandomYourFrozenString">Random your frozen string.</param>
        private static void GetRandomResponseStrings(List<string> ResponseOnFireList, List<string> ResponseHotList,
            List<string> ResponseVeryHotList, List<string> ResponseWarmList, List<string> ResponseGettingColdList,
            List<string> ResponseColdList, List<string> ResponseVeryColdList, List<string> ResponseYourFrozenList, 
            out string RandomOnFireString, out string RandomHotString, out string RandomVeryHotString, out string RandomWarmString,
            out string RandomGettingColdString, out string RandomColdString, out string RandomVeryColdString, out string RandomYourFrozenString)
        {

            RandomOnFireString = GetRandomOnFireString();
            RandomVeryHotString = GetRandomVeryHotString();
            RandomHotString = GetRandomHotString();
            RandomWarmString = GetRandomWarmString();
            RandomGettingColdString = GetRandomGettingColdString();
            RandomColdString = GetRandomColdString();
            RandomVeryColdString = GetRandomVeryColdString();
            RandomYourFrozenString = GetRandomYourFrozenString();

        }

        #endregion
        #region Number Guess 100 Input
        /// <summary>
        /// Number guess input.
        /// </summary>
        /// <returns>The guess input.</returns>
        private static int NumberGuess100Input()
        {
            bool validResponse;
            int usersGuess;

            do
            {
                validResponse = false;
                Console.Write("\t|| Please choose a number: ");

                if (int.TryParse(Console.ReadLine(), out usersGuess) && (usersGuess > 0)
                 && (usersGuess <= 100))
                {
                    validResponse = true;
                }
                else
                {
                    Console.CursorVisible = false;
                    Console.WriteLine("\t||                                            ");
                    Console.WriteLine("\t|| Please enter a valid numerical value");
                    Console.WriteLine("\t||                                            ");
                }
            } while (!validResponse);

            return usersGuess;
        }

        #endregion
        #region Number Guess 1000 Input
        /// <summary>
        /// Number guess input.
        /// </summary>
        /// <returns>The guess input.</returns>
        private static int NumberGuess1000Input()
        {
            bool validResponse;
            int usersGuess;

            do
            {
                validResponse = false;
                Console.Write("\t|| Please choose a number: ");

                if (int.TryParse(Console.ReadLine(), out usersGuess) && (usersGuess > 0)
                 && (usersGuess <= 1000))
                {
                    validResponse = true;
                }
                else
                {
                    Console.CursorVisible = false;
                    Console.WriteLine("\t||                                            ");
                    Console.WriteLine("\t|| Please enter a valid numerical value");
                    Console.WriteLine("\t||                                            ");
                }
            } while (!validResponse);

            return usersGuess;
        }

        #endregion
        #region Get Random String On Fire
        /// <summary>
        /// Gets the random on fire string.
        /// </summary>
        /// <returns>The random on fire string.</returns>
        static string GetRandomOnFireString()
        {
            List<string> ResponseOnFireList = new List<string>
            {
                "You are on Fire!!",
                "You'r Keyboard is on Fire!!",
                "You'r Monitor is on Fire!!",
                "You are playing with Fire, you better watch it!!",
                "Ahhh, Fire, Fire you'r on Fire!!",
                "You'r so Hot you are on Fire, no really I am serious!!"
            };
            Random ResponseOnFireRandom = new Random();
            string RandomOnFireString = ResponseOnFireList[ResponseOnFireRandom.Next(ResponseOnFireList.Count)];

            return RandomOnFireString;
        }

        #endregion
        #region Get Random Very Hot String
        /// <summary>
        /// Gets the random very hot string.
        /// </summary>
        /// <returns>The random very hot string.</returns>
        static string GetRandomVeryHotString()
        {
            List<string> ResponseVeryHotList = new List<string>
            {
                "You are getting Very Hot, you'r face is turnning red",
                "You'r Phone is getting Very Hot, be carefull\n\t|| it mighty EXPLODE!!!.",
                "Hmm, Its Very Hot in here, you are starting to sweat,\n\t|| just fyi.",
                "Why is this always about you? I am Very Hot too,\n\t|| I won the model of the Year award.",
                "I'm too Hot for my shirt, too Hot for my shirt, So Hot it hurts..\n\t|| What? Not a 90's Kid? ",
                "You'r so very Hot, I might need to take a cold shower..\n\t|| I mean...you might need to..Errr nevermind."
            };
            Random ResponseVeryHotRandom = new Random();
            string RandomVeryHotString = ResponseVeryHotList[ResponseVeryHotRandom.Next(ResponseVeryHotList.Count)];

            return RandomVeryHotString;
        }

        #endregion
        #region Get Random Hot String
        /// <summary>
        /// Gets the random hot string.
        /// </summary>
        /// <returns>The random hot string.</returns>
        static string GetRandomHotString()
        {
            List<string> ResponseHotList = new List<string>
            {
                "You are getting Hot, you might want to turn on our A/C!",
                "You'r Computer CPU is running Hot, I think I see smoke.",
                "Hmm, you are getting Hot, just fyi.",
                "You should turn down your furnace, its really starting\n\t|| to get Hot in here.",
                "I'm too Hot for my shirt, too Hot for my shirt, So Hot it hurts..\n|| What? Not a 90's Kid? ",
                "You'r so Hot you are.. well Hot, What? I never said I was funny!!"
            };
            Random ResposneHotRandom = new Random();
            string RandomHotString = ResponseHotList[ResposneHotRandom.Next(ResponseHotList.Count)];

            return RandomHotString;
        }

        #endregion
        #region Get Random Warm String
        /// <summary>
        /// Gets the random warm string.
        /// </summary>
        /// <returns>The random warm string.</returns>
        static string GetRandomWarmString()
        {
            List<string> ResponseWarmList = new List<string>
            {
                "I am starting to Warm up to you!",
                "Warm Warm and Warm, no I am not trying to rub it in.",
                "I Warmed your chair for you. You shouldn't leave your spare\n\t|| key under your welcome matt, just fyi.",
                "It's a Warm Anartic Fall if there ever was one",
                //"",
                //""
            };
            Random ResposneWarmRandom = new Random();
            string RandomWarmString = ResponseWarmList[ResposneWarmRandom.Next(ResponseWarmList.Count)];

            return RandomWarmString;
        }

        #endregion
        #region Get Random Getting Cold String
        /// <summary>
        /// Gets the random getting cold string.
        /// </summary>
        /// <returns>The random getting cold string.</returns>
        static string GetRandomGettingColdString()
        {
            List<string> ResponseGettingColdList = new List<string>
            {
                "Its Getting Cold out side, You can come in,\n\t|| but you can't stay here,...Wait what?",
                "There is a saying Getting Cold is a virtue",
                "Your not Getting Cold feet are you?",
                "So since its Getting Cold outside can I spend the night, I ll\n\t|| Make waffles in the morning.." +
                "\n\t|| that didn't come out right.",
                //"",
                //""
            };
            Random ResposneGettingColdRandom = new Random();
            string RandomGettingColdString = ResponseGettingColdList[ResposneGettingColdRandom.Next(ResponseGettingColdList.Count)];

            return RandomGettingColdString;
        }

        #endregion
        #region Get Random Cold String
        /// <summary>
        /// Gets the random cold string.
        /// </summary>
        /// <returns>The random cold string.</returns>
        static string GetRandomColdString()
        {
            List<string> ResponseColdList = new List<string>
            {
                "I really can't stay..., Baby its Cold outside",
                "Cold is the hearts of those who worship money",
                "Winter is Cold here in Michigan, does it snow where you live",
                "So if the Antartic is considered Cold than what is pluto considered?",
                //"",
                //""
            };
            Random ResposneColdRandom = new Random();
            string RandomGettingColdString = ResponseColdList[ResposneColdRandom.Next(ResponseColdList.Count)];

            return RandomGettingColdString;
        }

        #endregion
        #region Get Random Very Cold String
        /// <summary>
        /// Gets the random very cold string.
        /// </summary>
        /// <returns>The random very cold string.</returns>
        static string GetRandomVeryColdString()
        {
            List<string> ResponseVeryColdList = new List<string>
            {
                "I really can't stay..., Baby its Cold outside",
                "You have a Very Cold personality. Its rude to ignore me ",
                "Those with Very Cold hearts reach the mountain peak with the\n\t|| least amount of effort",
                "Did you no that the North Pole is a Very Cold Place? \n\t|| ..Psst Santa isn't real either...I was shocked to!",
                //"",
                //""
            };
            Random ResposneVeryColdRandom = new Random();
            string RandomGettingvColdString = ResponseVeryColdList[ResposneVeryColdRandom.Next(ResponseVeryColdList.Count)];

            return RandomGettingvColdString;
        }

        #endregion
        #region Get Random Your Frozen String
        /// <summary>
        /// Gets the random your frozen string.
        /// </summary>
        /// <returns>The random your frozen string.</returns>
        static string GetRandomYourFrozenString()
        {
            List<string> ResponseYourFrozenList = new List<string>
            {
                "I think hell has Frozen Over",
                "You are as Frozen as Ice screan, Can I have a taste?",
                "Your *** is Frozen, What? I will let you fill that one in.",
                "So Have you seen the movie Frozen yet?",
                "Be weary of a Frozen Heart, It might melt and make\n\t|| a really big mess",
                //""
            };
            Random ResponseYourFrozenRandom = new Random();
            string RandomYourFrozenString = ResponseYourFrozenList[ResponseYourFrozenRandom.Next(ResponseYourFrozenList.Count)];

            return RandomYourFrozenString;
        }

        #endregion
        #region Math Operation for 100 Numbers
        /// <summary>
        /// Maths the operation for 100 numbers.
        /// </summary>
        /// <returns>The operation for100 numbers.</returns>
        /// <param name="usersQuess">Users quess.</param>
        /// <param name="answer">Answer.</param>
        static int MathOperationForGuessNumbersOutpot(int usersQuess, int answer)
        {
            int output = usersQuess - answer;
            if (output <= 0)
            {
                output = answer - usersQuess;
            }

            return output;
        }

        #endregion
        /// <summary>
        /// Commands the prompt.
        /// </summary>
        static void ContinuePrompt()
        {
            Console.CursorVisible = false;
            Console.WriteLine("\n\tPress any key to continue.\n");
            Console.ReadKey();

        }

        /// <summary>
        /// Screens the header.
        /// </summary>
        /// <param name="Header">Header.</param>
        static void ScreenHeader(string Header)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine($"\n\t\t{Header}");
        }

        /// <summary>
        /// Menus the prompt.
        /// </summary>
        /// <param name="menuName">Menu name.</param>
        static void MenuPrompt(string menuName)
        {
            Console.CursorVisible = false;
            Console.WriteLine($"\n\tPress any key to return to the {menuName} Menu.\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the random number.
        /// </summary>
        /// <returns>The random number.</returns>
        /// <param name="int1">Int1.</param>
        /// <param name="int2">Int2.</param>
        static int GetRandomNumber(int int1,int int2)
        {
            Random random = new Random();
            return random.Next(1,100);
        }
    }
}
