public class Exercise03
{
    public static void One()
    {
        int max = 500;
        // Check if max exceeds the maximum value that byte can store
        if (max > byte.MaxValue)
        {
            Console.WriteLine("Warning: 'i' is a byte and will overflow before reaching max!");
            Console.WriteLine("Press ENTER to continue anyway, or type 'E' to exit.");
            string input = Console.ReadLine();
            if (input == "E")
            {
                return;
            }
        }

        /*The program enters an infinite loop. byte can only store values from 0 to 255.
        Once i reaches 255 and increases, it wraps around to 0 (overflow), so i < max is always true.*/
        for (byte i = 0; true; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Two()
    {
        int totalRows = 5;
        for (int row = 1; row <= totalRows; row++)
        {
            // Print spaces: total number of lines - current number of lines
            for (int space = 1; space <= (totalRows - row); space++)
            {
                Console.Write(" ");
            }

            // Print stars: print (2 * row - 1) stars in row N
            for (int star = 1; star <= ((2 * row) - 1); star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public static void Three()
    {
        bool play = true;
        int correctNumber = new Random().Next(3) + 1;
        while (play)
        {
            Console.Write("Input(between 1 to 3): ");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Answer is outside of the range of numbers.");
            } else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Guess too high");
            } else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Guess too low");
            } else
            {
                Console.WriteLine("Got the correct answer.");
                play = false;
            }
        }
    }

    public static void Four()
    {
        Console.Write("Enter your birth date (yyyy-MM-dd): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
        {
            DateTime today = DateTime.Today;
            int ageInDays = (today - birthDate).Days;
            Console.WriteLine($"You are {ageInDays} days old.");
            int daysToNextAnniversary = 10000 - (ageInDays % 10000);
            DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
            Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversary}");
        } else
        {
            Console.WriteLine("You entered an incorrect date.");
        }
    }

    public static void Five()
    {
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour;
        if (hour >= 0 && hour <= 10)
        {
            Console.WriteLine("Good Morning");
        }

        if (hour > 10 && hour <= 17)
        {
            Console.WriteLine("Good Afternoon");
        }

        if (hour > 17 && hour <= 21)
        {
            Console.WriteLine("Good Evening");
        }

        if ((hour > 21 && hour < 24))
        {
            Console.WriteLine("Good Night");
        }
    }

    public static void Six()
    {
        int max = 24;
        // i = 1 ~ 4
        for (int i = 1; i <= 4; i++)
        {
            // j = 0~24
            for (int j = 0; j <= max; j += i)
            {
                if (j < max)
                    Console.Write($"{j},");
                else
                    Console.Write($"{j}");
            }

            Console.WriteLine();
        }
    }
}
