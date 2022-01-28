namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Linq;

public static class Program
{
    public static int Main(
        string[] args)
    {
        var secret = args[0]
            .Split(",")
            .Select(x => Enum.Parse<PegColor>(x))
            .ToArray();
        var guess = args[1]
            .Split(",")
            .Select(x => Enum.Parse<PegColor>(x))
            .ToArray();

        var (correctGuesses, misplacedGuesses) = new Mastermind()
            .EvaluateGuess(guess, secret);

        return 0;
    }
}
