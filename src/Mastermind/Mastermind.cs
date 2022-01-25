namespace CleanCode.Academy.MastermindDojo.Mastermind;

using System;
using System.Linq;

public class Mastermind
{
    public (int, int) Do(PinColor[] pinColors, PinColor[] pinColors2)
    {
        var numberOfWellPlaced = pinColors
            .Zip(pinColors2)
            .Where(x => x.First == x.Second)
            .Count();

        var groupBy1 = pinColors.GroupBy(x => x, (
            color,
            colors) => (color, colors.Count()));
        var groupBy2 = pinColors2.GroupBy(x => x, (
            color,
            colors) => (color, colors.Count()))
            .ToDictionary(x => x.color, x => x.Item2);

        var count = groupBy1
            .Where(x => groupBy2.ContainsKey(x.color))
            .Select(x => Math.Min(groupBy2[x.color], x.Item2))
            .Count();

        return (numberOfWellPlaced, count-numberOfWellPlaced);
    }
}
