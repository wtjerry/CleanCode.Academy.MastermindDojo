namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System.Collections.Generic;
using System.Linq;

public class Mastermind
{
    public (int correctPegs, int misplacedPegs) EvaluateGuess(
        PegColor[] guess,
        PegColor[] secret)
    {
        int misplacedPegs = 0;
        List<PegColor> correctPegs = new List<PegColor>();
        //st<bool> correctPegs = new List<bool>;

        for (int i = 0; i < guess.Length; i++)
        {
            if (guess[i] == secret[i])
            {
                correctPegs.Add(guess[i]);
                //correctPegs[i] = true
            }
        }

        for (int i = 0; i < guess.Length; i++)
        {
            if (!correctPegs.Contains(guess[i]))
            {
                misplacedPegs++;
            }
        }

        return (correctPegs.Count, misplacedPegs);
    }
}
