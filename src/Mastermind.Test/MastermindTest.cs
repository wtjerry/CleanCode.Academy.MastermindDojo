namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void TestExactMatch()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Yellow },
            new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void TestNoMatch()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Yellow, PinColor.Yellow },
            new[] { PinColor.Red, PinColor.Pink });

        result.Should().Be((0, 0));
    }

    [Fact]
    public void TestNoExactMatch()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Yellow, PinColor.Red },
            new[] { PinColor.Red, PinColor.Pink });

        result.Should().Be((0, 1));
    }

    [Fact]
    public void TestFourColors()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Yellow, PinColor.Yellow, PinColor.Red, PinColor.Red },
            new[] { PinColor.Pink, PinColor.Red, PinColor.Red, PinColor.Pink });

        result.Should().Be((1, 1));
    }

    [Fact]
    public void TestWallExample()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Red, PinColor.Red, PinColor.Red, PinColor.Green, PinColor.Green, PinColor.Blue },
            new[] { PinColor.Green, PinColor.Green, PinColor.Red, PinColor.Green, PinColor.Blue, PinColor.Blue });

        result.Should().Be((3, 1));
    }
}
