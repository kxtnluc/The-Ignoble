using OpenAI.Chat;

public static class Jeanne
{
    public static string Name = "Jeanne";
    public static int Sanguine = 5;
    public static int Choleric = 3;
    public static int Phlegmatic = 8;
    public static int Melancholic = 1;

    public static void Speak(string words, bool wait = true, bool withName = false)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        if (withName)
        {
            Console.WriteLine($" [ {Name} ] ");
        }
        Console.WriteLine(words);
        if (wait)
        {
            Console.ReadKey();
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void SayTo(string words, ChatClient client)
    {
        gpt = new ChatClient(client)
    }
}