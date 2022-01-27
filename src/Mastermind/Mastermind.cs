namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System.Linq;

public class Mastermind
{
    public (int correctGuesses, int misplacedGuesses) EvaluateGuess(
        PegColor[] guess,
        PegColor[] secret)
    {
        int correctGuesses = 0;
        int misplacedGuesses = 0;


        for (int i = 0; i < guess.Length; i++)
        {
            if (guess[i] == secret[i])
            {
                correctGuesses++;
            }
            else
            {
                if (secret.Contains(guess[i]))
                {
                    misplacedGuesses++;
                }
            }
        }

        return (correctGuesses, misplacedGuesses);
    }
}
