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

        var UnmatchedSecret = new Dictionary<PinColor, int>();
        var UnmatchedGuess = new Dictionary<PinColor, int>();

        for (int i = 0; i < secret.Length; ++i)
        {
            if (secret[i] == guess[i])
            {
                wellplaced++;
            }
            else
            {
                if (UnmatchedSecret.ContainsKey(secret[i]))
                    UnmatchedSecret[secret[i]] += 1;
                else
                {
                    UnmatchedSecret.Add(secret[i], 1);
                }

                if (UnmatchedGuess.ContainsKey(secret[i]))
                    UnmatchedGuess[secret[i]] += 1;
                else
                {
                    UnmatchedGuess.Add(secret[i], 1);
                }
            }
        }

        foreach (var currentElement in UnmatchedSecret)
        {
            if (UnmatchedGuess.ContainsKey(currentElement.Key))
            {
                var min = Math.Min(currentElement.Value, UnmatchedGuess[currentElement.Key]);
                misplaced += min;
            }
        }

        //TODO handle misplaced



        return (wellplaced, misplaced);
    }
}
