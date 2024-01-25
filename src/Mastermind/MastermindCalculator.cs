using System.Linq;

namespace CleanCode.Academy.MastermindDojo.Mastermind;

public class MastermindCalculator
{
    public (int, int) Compare(PinColor[] pinColorsGuess, PinColor[] pinColorsSecret)
    {
        var rightGuess = 0;
        var rightMisplacedGuess = 0;
        for (var i = 0; i < pinColorsGuess.Length; i++)
        {
            if (pinColorsGuess[i] == pinColorsSecret[i])
            {
                rightGuess++;
            }
            else if(pinColorsSecret.Contains(pinColorsGuess[i]))
            {
                rightMisplacedGuess++;
            }
        }
        return (rightGuess, rightMisplacedGuess);
    }
}
