namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Theory]
    [InlineData(new[] { PinColor.Yellow }, new[] { PinColor.Yellow }, 1, 0)]
    [InlineData(new[] { PinColor.Yellow }, new[] { PinColor.Blue }, 0, 0)]
    [InlineData(new[] { PinColor.Yellow, PinColor.Blue }, new[] { PinColor.Blue, PinColor.Green }, 0, 1)]
    [InlineData(new[] { PinColor.Yellow, PinColor.Blue, PinColor.Green }, new[] { PinColor.Yellow, PinColor.Green, PinColor.Pink }, 1, 1)]
    public void Test1(PinColor[] a, PinColor[] b, int c, int d)
    {
        new Mastermind().Do(a, b).Should().Be((c,d));
    }
}
