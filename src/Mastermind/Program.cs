namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;

public static class Program
{
    public static int Main()
    {
        var mastermind = new Mastermind();
        var secret = new[] { PinColor.Red, PinColor.Green };
        var guess = new[] { PinColor.Yellow, PinColor.Green };

        Console.WriteLine("Secret is: " + string.Join(", ", secret));
        Console.WriteLine("Guess is: " + string.Join(", ", guess));

        var valueTuple = mastermind.Do(
            secret,
            guess);


        Console.WriteLine($"Result is: ({valueTuple.Item1}, {valueTuple.Item2}");

        return 0;
    }
}
