namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

public class Mastermind
{
    public (int, int) Do(
        PinColor[] guessedPecColors,
        PinColor[] secretPecColors)
    {
        var wellPlaced = 0;
        var missPlaced = 0;
        //var foundColors = new Dictionary<int, PinColor>();

        if (!guessedPecColors.Length.Equals(secretPecColors.Length))
        {
            throw new Exception("No valid list colors");
        }

        if (guessedPecColors.SequenceEqual(secretPecColors))
        {
            wellPlaced = (guessedPecColors.Length);
            return (wellPlaced, missPlaced);
        }

        var wellPlacedIndexes = new List<PinColor>();
        for (int i = 0; i < guessedPecColors.Length; i++)
        {
            if (guessedPecColors[i] == secretPecColors[i])
            {
                // foundColors.Add(i, pinColors[i]);
                wellPlaced++;
                continue;
            }

            if (Array.IndexOf(guessedPecColors, secretPecColors[i]) != -1)
            {
                missPlaced++;
            }
            // else
            // {
                // var index = Array.IndexOf(
                //     pinColors2,
                //     pinColors[i]);
                // if (index != -1 && pinColors[i] != pinColors2[index])
                // {
                //     missPlaced++;
                // }


                // for (int j = 0; j < pinColors.Length; j++)
                // {
                //     if (i == j && pinColors[i].Equals(pinColors[j]))
                //     {
                //         wellPlaced++;
                //     }
                //
                // }
            // }
        }




        return (wellPlaced, missPlaced);
    }
}
