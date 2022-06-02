namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;

public class Mastermind
{
    public (int nameA, int) guess(
        PinColor[] secretArray,
        PinColor[] guessArray)
    {
        var correctPlaced = 0;
        var missplaced = 0;

        if (secretArray == null)
        {
            return (0, 0);
        }

        for (int i = 0; i < secretArray.Length; i++)
        {
            if (Array.IndexOf(
                    guessArray,
                    secretArray[i]) == i)
            {
                correctPlaced++;
            }
            else if (Array.IndexOf(
                         guessArray,
                         secretArray[i]) > -1)
            {
                missplaced++;
            }
        }

        return (correctPlaced, missplaced);
    }
}
