namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindCalculatorTest
{
    [Fact]
    public void Test1RightGuess()
    {
        var result = MastermindCalculator.Compare(new[] { PinColor.Yellow }, new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }
    [Fact]
    public void Test1RightMisplacedGuess()
    {
        var result = MastermindCalculator.Compare(
            new[] { PinColor.Purple, PinColor.Yellow },
            new[] { PinColor.Yellow, PinColor.Green });

        result.Should().Be((0, 1));
    }
    [Theory]
    [InlineData(
        new[] { PinColor.Purple, PinColor.Yellow, PinColor.Yellow },
        new[] { PinColor.Yellow, PinColor.Green, PinColor.Blue })]
    public void Test23MultipleMisplacedGuess(PinColor[] pinColorsGuess, PinColor[] pinColorsSecret)
    {
        var result = MastermindCalculator.Compare(
            pinColorsGuess,
            pinColorsSecret);

        result.Should().Be((0, 1));
    }
    [Fact]
    public void Test3()
    {
        var result = MastermindCalculator.Compare(
            new[] { PinColor.Yellow, PinColor.Green, PinColor.Blue, PinColor.Yellow },
            new[] { PinColor.Purple, PinColor.Yellow, PinColor.Yellow, PinColor.Red });

        result.Should().Be((0, 2));
    }
}
