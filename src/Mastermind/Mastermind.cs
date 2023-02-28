namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Collections.Generic;
using System.Linq;

public class Mastermind
{
    public (int guess, int position) Do(
        PegColor[] secret,
        PegColor[] guess)
    {
        if (secret.Length != guess.Length)
            throw new InvalidOperationException("Dimensions do not mathc.");

        var matchCount = CountMatches(
            secret,
            guess);
        return matchCount;
    }

    private (int, int) CountMatches(
        PegColor[] secret,
        PegColor[] guess)
    {
        int positionMatchCount = 0;
        int colorMatchCount = 0;

        var colorList = new List<PegColor>();
        var guessMap = new Dictionary<PegColor, List<int>>();
        var secretMap = new Dictionary<PegColor, List<int>>();

        for (int i = 0; i < guess.Length; i++)
        { // TryAdd vewenden
            if (guessMap.ContainsKey(guess[i])) guessMap[guess[i]].Add(i);
            else guessMap.Add(guess[i], new List<int>(){i});
        }

        for (int i = 0; i < secret.Length; i++)
        {
            if (secretMap.ContainsKey(secret[i])) secretMap[secret[i]].Add(i);
            else secretMap.Add(secret[i], new List<int>(){i});
        }

        (int exactMatch, int colorMatch) result;
        // min (l1-x, l2-x)
        foreach (var singleGuess in guessMap)
        {

            var key = singleGuess.Key;
            if (secretMap.ContainsKey(key))
            {
                var matchEquals  = secretMap[singleGuess.Key].Intersect(guessMap[singleGuess.Key]).Count();
                result.exactMatch += matchEquals;
                result.colorMatch += Math.Min(
                    secretMap[singleGuess.Key].Count - matchEquals,
                    guessMap[singleGuess.Key].Count - matchEquals);
            }
        }

        // (int i = 0; i < secret.Length; i++)
        // {
        //     for (var j = 0; j < guess.Length; j++)
        //     {
        //         colorMatchCount += (i != j && secret[i] == guess[j]) ? 1: 0;
        //     }
        //
        //     positionMatchCount += secret[i] == guess[i] ? 1 : 0;
        // }

        return (positionMatchCount, colorMatchCount);
    }
}
