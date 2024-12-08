using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! What is your name?");
        string playerName = Console.ReadLine();

        Console.WriteLine($"\nWelcome, {playerName}! I will ask you a few questions about games. Let's get started!");

        int score = 0;

        Console.WriteLine("\n1. What is your favorite game?");
        Console.WriteLine("a) God of War\nb) Red Dead Redemption\nc) Elden Ring\nd) Other");
        char answer1 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer1 == 'a' || answer1 == 'b' || answer1 == 'c') score++;

        Console.WriteLine("\n2. Do you prefer sports games over other types?");
        Console.WriteLine("a) Yes\nb) No");
        char answer2 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer2 == 'b') score++;

        Console.WriteLine("\n3. How often do you play online games? (LoL, Valorant, CS:GO, Dota)");
        Console.WriteLine("a) Every day\nb) Never\nc) Only when I have no other games");
        char answer3 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer3 == 'b') score += 1;
        if (answer3 == 'c') score += 2;

        Console.WriteLine("\n4. If you could give a Game of the Year award to one of the following, which would it be?");
        Console.WriteLine("a) Red Dead Redemption\nb) FIFA 24\nc) Black Myth Wukong");
        char answer4 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer4 == 'a') score += 2;
        if (answer4 == 'c') score += 1;


        Console.WriteLine($"\nThank you, {playerName}! Here are your results:");
        if (score == 6)
        {
            Console.WriteLine("Wow! You are a true gaming connoisseur! If you gave the Game of the Year award, I'd trust your choice completely!");
        }
        else if (score >= 4)
        {
            Console.WriteLine("Pretty good! You may not be the ultimate gaming expert, but you have your own unique style, and it's quite impressive.");
        }
        else if (score >= 2)
        {
            Console.WriteLine("You need to expand your gaming horizons. Try giving other games a chance, buddy!");
        }
        else
        {
            Console.WriteLine("Buddy, don't go around calling yourself a gamer! You hardly know anything about games!");
        }

        Console.WriteLine("\nThanks for playing! See you next time!");
    }
}

