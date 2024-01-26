using System.Linq;

namespace CleanCode.Academy.MastermindDojo.Mastermind;

public class MastermindCalculator
{
    public static (int, int) Compare(PinColor[] pinColorsGuess, PinColor[] pinColorsSecret)
    {
        var rightGuess = 0;
        var rightMisplacedGuessCount = 0;
        var rightMisplacedGuessesLength = new bool[pinColorsGuess.Length];
        for (var i = 0; i < pinColorsGuess.Length; i++)
        {
            if (pinColorsGuess[i] == pinColorsSecret[i])
            {
                rightGuess++;
            }
            else if(pinColorsSecret.Contains(pinColorsGuess[i]))
            {
                rightMisplacedGuessCount = FindRightMisplacedGuess(pinColorsGuess, pinColorsSecret, i, rightMisplacedGuessCount, rightMisplacedGuessesLength);
            }
        }
        return (rightGuess, rightMisplacedGuessCount);
    }

    private static int FindRightMisplacedGuess(PinColor[] pinColorsGuess, PinColor[] pinColorsSecret, int i, int rightMisplacedGuess, bool[] rightMisplacedGuessesLength)
    {
        for (var j = 0; j < rightMisplacedGuessesLength.Length; j++)
        {
            var isMisplacedGuess = pinColorsGuess[i] == pinColorsSecret[j] && rightMisplacedGuessesLength[j] == false;
            if (isMisplacedGuess)
            {
                rightMisplacedGuessesLength[j] = true;
                rightMisplacedGuess++;
                break;
            }
        }

        return rightMisplacedGuess;
    }
}
