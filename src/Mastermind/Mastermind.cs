namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System.Linq;

public class Mastermind
{
    private int getCorrectPositions(
        PegColor[] pegSecret,
        PegColor[] pegGuess)
    {
        int counter = 0;
        for (int i = 0; i < pegGuess.Length; i++)
        {
            if (pegSecret[i] == pegGuess[i])
            {
                counter++;
            }
        }

        return counter;
    }

    private int getCorrectColours(
        PegColor[] pegSecret,
        PegColor[] pegGuess)
    {
        var intersect =
            pegSecret.Intersect(pegGuess);

        return intersect.Count();
    }

    public (int CorrectPositions, int CorrectColors) Compare(
        PegColor[] pegSecret,
        PegColor[] pegGuess)
    {
        if (pegSecret == null || pegGuess == null)
        {
            return (0, 0);
        }

        int correctPositions = getCorrectPositions(
            pegSecret,
            pegGuess);
        int correctColors = getCorrectColours(
            pegSecret,
            pegGuess);

        return (correctPositions, correctColors - correctPositions);
    }
}
