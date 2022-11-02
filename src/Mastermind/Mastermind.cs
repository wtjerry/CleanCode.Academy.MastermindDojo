namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Collections.Generic;
using System.Linq;

public class Mastermind
{
    public (int, int) Do(PinColor[] secret, PinColor[] guess)
    {
        if (secret.Length != guess.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(secret),"Arrays do not have a matching size.");
        }

        var correct = new List<int>();
        var misplaced = new List<int>();

        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                correct.Add((int)guess[i]);
            }
            else if (secret.Contains(guess[i]))
            {
                misplaced.Add((int)guess[i]);
            }
        }

        return (correct.Count, misplaced.Count);
    }
}
