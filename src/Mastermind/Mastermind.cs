namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Linq;

public class Mastermind
{
    public (int, int) Do(PinColor[] secret, PinColor[] guess)
    {
        var correct = 0;
        var misplaced = 0;

        if (secret.Length != guess.Length)
            throw new Exception("Array Lengths do not match.");

        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                correct++;
            }
            else if (secret.Contains(guess[i]))
            {
                misplaced++;
            }
        }

        return (correct,misplaced);
    }
}
