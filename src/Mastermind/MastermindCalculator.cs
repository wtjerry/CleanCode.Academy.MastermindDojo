using System.Linq;

namespace CleanCode.Academy.MastermindDojo.Mastermind;

public class MastermindCalculator
{
    public (int, int) Compare(PinColor[] pinColorsGuess, PinColor[] pinColorsSecret)
    {
        // array bool  // guessIndex -> Right/MisplacedGuess
        // bool default is false,
        var rightMisplacedGuesses = new bool[pinColorsGuess.Length];
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
                for (var j = 0; j < rightMisplacedGuesses.Length; j++)
                {
                    if (pinColorsGuess[i] == pinColorsSecret[j] && rightMisplacedGuesses[j] == false)
                    {
                        rightMisplacedGuesses[j] = true;
                    }

                    if (rightMisplacedGuesses[j])
                    {
                        rightMisplacedGuess++;
                        break;
                    }
                }
                // loop item from array(secret)
                // array (secret) = true
                // if item=true
                //    rightMisplacedGuess++
                //    stop loop through array
            }
        }
        return (rightGuess, rightMisplacedGuess);
    }
}
