namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindCalculatorTest
{
    [Fact]
    public void Test1()
    {
        var mastermind = new MastermindCalculator();
        var result = mastermind.Compare(new[] { PinColor.Yellow }, new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }
    [Fact]
    public void Test2()
    {
        var mastermind = new MastermindCalculator();
        var result = mastermind.Compare(new[] { PinColor.Purple, PinColor.Yellow }, new[] { PinColor.Yellow, PinColor.Green });

        result.Should().Be((0, 1));
    }
}
