namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;

public static class Program
{
    // args will contain:
    // [
    // Yellow,Blue,Pink
    // Yellow,Yellow,Blue
    // ]
    public static int Main(string[] args)
    {
        Parser.Parse(args);

        Console.WriteLine(string.Join("\n", args));

        return 0;
    }


}
