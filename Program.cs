using System;
using System.Collections.Generic;
using OpenAI;

class Program
{
    static void Main()
    {
        #region Variables
        Player player = new();
        #endregion

        #region AI
        var apiKey = "";
        var client = new OpenAIClient(apiKey);
        #endregion

        // Intro();
        ActOne();
    }



    private static void Intro()
    {
        Write("Welcome");
        Write("What is your name?");
        string playerName = Console.ReadLine() ?? "unkown";
        Write(playerName + "... Perfect.");

        Console.Clear();
    }

    private static void ActOne()
    {
        LineBreak();
        WriteSlow(@"
    May 4th
        ", 300, false);
        WriteSlow(@"
    1789
        ", 450);
        LineBreak();
        WriteSlow(@$"
    The ashen clouds hang overhead as you step out into 
    the streets of Paris, onto [ Rue Saint Denis ]
        ", 35, false);
        WriteSlow(@$"
    Frowning faces and slumed shoulders dot the tattered streets of the city, 
    for in Paris the days are long and the years only longer.
        ");
        // WriteSlow("Life is pitiful.", 400);

        Console.Clear();
        // Interaction with Jeanne
        Jeanne.Speak("Hello!", false, true);
        Prompt();
        Jeanne.SayTo(Console.ReadLine() ?? "");
    }








    // Utils ---------------------------------------------------------------
    private static void Wait()
    {
        Console.ReadKey();
    }

    private static void Write(string words, bool wait = true)
    {
        Console.WriteLine(words);
        if (wait)
        {
            Wait();
        }
    }

    private static void Prompt()
    {
        Console.Write("- ");
    } 
    private static void WriteSlow(string words, int interval = 50, bool wait = true)
    {
        foreach (char c in words)
        {
            Console.Write(c);
            if (!char.IsWhiteSpace(c))
            {
                Thread.Sleep(interval); // pause between letters
            }
        }
        Console.WriteLine();
        if (wait)
        {
            Wait();
        }
    }

    private static void MoveCursor()
    {
        if (Console.CursorTop > 0)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }

    private static void LineBreak(int lines = 1)
    {
        for (int i = 0; i < lines; i++)
        {
            Console.WriteLine();
        }
    }
}