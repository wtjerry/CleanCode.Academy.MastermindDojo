using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode.Academy.MastermindDojo.Mastermind;

public class Mastermind
{
    public (int, int) Evaluate(PinColor[] solution, PinColor[] guess)
    {
        var correctPlaces = 0;
        var correctColors = 0;
        var guessHistogram = new Dictionary<PinColor, int>();
        var solutionHistogram = new Dictionary<PinColor, int>();
        for (int i = 0; i < solution.Length; i++)
        {
            guessHistogram[guess[i]] += 1;
            solutionHistogram[solution[i]] += 1;
            correctPlaces += solution[i] == guess[i] ? 1 : 0;
        }
        foreach (PinColor color in System.Enum.GetValues(typeof(PinColor)))
        {
            try
            {
                correctColors += Math.Min(guessHistogram[color], solutionHistogram[color]);
            }
            catch
            {
            }
        }

        return (correctPlaces, correctColors - correctPlaces);
    }
}
