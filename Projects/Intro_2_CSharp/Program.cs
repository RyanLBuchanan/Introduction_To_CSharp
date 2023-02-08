namespace Intro_2_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a field is a class member (aka variable)
            Actor joleneBlalock = new Actor();

            Robot hoverBot = new Robot();

            string actorName = "Jolene Blalock";
            joleneBlalock.lines = "Delightful, a new programming rube.\nVery well.\n";
            joleneBlalock.role = "Provocative Vulcanness";

            Console.WriteLine($"{joleneBlalock.SayLines()}My name is {actorName}");
            Console.WriteLine($"My role in this irrational development is {joleneBlalock.role}.\nDo you have some witty repartee, hmmm?");
            string response = Console.ReadLine();
            Console.WriteLine($"Your response, albeit irrelevant in the grand scheme of things, is . . . '{response}'.\n");
            hoverBot.Introduction();
        }
    }
}