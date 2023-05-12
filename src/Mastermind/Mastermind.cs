namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Collections.Generic;
using System.Linq;

public class Mastermind
{
    public (int, int) Do(PinColor[] secret, PinColor[] guess)
    {
        int wellplaced = 0;
        int misplaced = 0;
        int colorCount = Enum.GetValues(typeof(PinColor)).Length;

        var UnmatchedSecret = new int[colorCount];
        var UnmatchedGuess = new int[colorCount];

        for (int i = 0; i < secret.Length; ++i)
        {
            if (secret[i] == guess[i])
            {
                wellplaced++;
            }
            else
            {
                UnmatchedSecret[(int)secret[i]]++;
                UnmatchedGuess[(int)guess[i]]++;
            }
        }


        for(int i = 0;
        i < colorCount; i++)
        {
            var min = Math.Min(currentElement.Value, UnmatchedGuess[currentElement.Key]);
                misplaced += min;
        }

        return (wellplaced, misplaced);
    }
}
