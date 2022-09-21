namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;

public static class Program
{
    public static int Main(string[] args)
    {
        // from PO: it's urgent, hurry!
        //
        // Our biggest client just told us we need that Mastermind solution NOW.
        // They need to be able to pass the secret and guess via program arguments
        // and expect the "number of well placed colors"
        // and the "number of correct but misplaced colors" as console output.
        //
        // I've even started implementing it for you: It almost works,
        // just a few little touch-ups necessary.
        // With my help you should finish it by EOD, right!?

        // var gues = args[1].Split(,).Forech(x => IDK maybe cast to PinColor?
        // // todo: do the mastermind logic
        // printf(r)
        // yes.. that should do it
        //"Blue,Yellow" "Yellow,Blue"

        var arg1 = args[0];
        var arg2 = args[1];

        var secret = arg1.Split(",");
        var guess = arg2.Split(",");

        var secretConverted = Mastermind.Convert(secret);
        var guessConverted = Mastermind.Convert(guess);
        var result = Mastermind.Guess(
            secretConverted,
            guessConverted);

        Console.WriteLine(result);
        return 0;
    }
}
