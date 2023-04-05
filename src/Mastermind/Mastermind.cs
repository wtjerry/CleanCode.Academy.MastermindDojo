namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

public class Mastermind
{
    public (int, int) Do(
        PinColor[] pinColors,
        PinColor[] pinColors2)
    {
        var wellPlaced = 0;
        var missPlaced = 0;
        var foundColors = new Dictionary<int, PinColor>();

        if (!pinColors.Length.Equals(pinColors2.Length))
        {
            throw new Exception("No valid list colors");
        }

        if (pinColors.SequenceEqual(pinColors2))
        {
            wellPlaced = (pinColors.Length);
            return (wellPlaced, missPlaced);
        }

        var wellPlacedIndexes = new List<PinColor>();
        for (int i = 0; i <= pinColors.Length; i++)
        {
            if (pinColors[i] == pinColors2[i])
            {
                foundColors.Add(i, pinColors[i]);
                wellPlaced++;
            }
            // for (int j = 0; j < pinColors.Length; j++)
            // {
            //     if (i == j && pinColors[i].Equals(pinColors[j]))
            //     {
            //         wellPlaced++;
            //     }
            //
            // }
        }




        return (wellPlaced, missPlaced);
    }
}
