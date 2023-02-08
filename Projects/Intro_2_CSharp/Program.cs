namespace Intro_2_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actor joleneBlalock = new Actor();

            joleneBlalock.lines = "That's not logical.";
            joleneBlalock.role = "Provocative Vulcanness";

            Console.WriteLine(joleneBlalock.SayLines());
            Console.WriteLine($"My role in this irrational development is {joleneBlalock.role}.");
        }
    }
}