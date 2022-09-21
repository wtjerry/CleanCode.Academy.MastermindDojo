namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void Test1()
    {
        var result = Mastermind.Guess(
            new[] { PinColor.Yellow },
            new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void TestMismatch()
    {
        var result = Mastermind.Guess(
            new[] { PinColor.Blue },
            new[] { PinColor.Yellow });

        result.Should().Be((0, 0));
    }

    [Fact]
    public void TestSeveralColorPositions()
    {
        var result = Mastermind.Guess(
            new[] { PinColor.Blue, PinColor.Yellow, PinColor.Blue, PinColor.Red },
            new[] { PinColor.Yellow, PinColor.Blue, PinColor.Yellow, PinColor.Blue });

        result.Should().Be((0, 3));
    }

    [Fact]
    public void TestBoth()
    {
        var result = Mastermind.Guess(
            new[] { PinColor.Blue, PinColor.Red, PinColor.Yellow },
            new[] { PinColor.Blue, PinColor.Yellow, PinColor.Red });

        result.Should().Be((1, 2));
    }

    [Fact]
    public void TestParse()
    {
        var result = Mastermind.Convert(
            new[] { "Blue", "Red", "Yellow" });

        PinColor[] shouldResult = new[]
        {
            PinColor.Blue,
            PinColor.Red,
            PinColor.Yellow
        };

        result.Should().BeEquivalentTo(shouldResult);
    }
}
