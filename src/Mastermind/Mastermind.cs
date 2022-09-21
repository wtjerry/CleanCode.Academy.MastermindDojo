namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Linq;

public class Mastermind
{
    public static PinColor[] Convert(
        string[] input)
    {
        PinColor[] result = new PinColor[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = Enum.Parse<PinColor>(input[i]);
        }

        return result;
    }

    public static (int postion, int color) Guess(
        PinColor[] pegSecret,
        PinColor[] pegGuess)
    {
        var matchingPosition = GetMachingPositions(
            pegSecret,
            pegGuess);

        var matchingColor = GetMachingColors(
            pegSecret,
            pegGuess);

        return (matchingPosition, matchingColor - matchingPosition);
    }

    private static int GetMachingPositions(
        PinColor[] pegSecret,
        PinColor[] pegGuess)
    {
        int counter = 0;
        for (int i = 0; i < pegSecret.Length; i++)
        {
            if (pegSecret[i] == pegGuess[i])
            {
                counter++;
            }
        }

        return counter;
    }

    private static int GetMachingColors(
        PinColor[] pegSecret,
        PinColor[] pegGuess)
    {
        var result = pegSecret.Intersect(pegGuess);
        return result.Count();
    }
}
