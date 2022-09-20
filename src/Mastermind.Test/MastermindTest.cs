namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void TestOnMatched()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Compare(
            new[] { PegColor.Yellow },
            new[] { PegColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void TestOnMismatched()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Compare(
            new[] { PegColor.Yellow },
            new[] { PegColor.Blue });

        result.Should().Be((0, 0));
    }

    [Fact]
    public void TestOnNullShouldReturnZero()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Compare(
            null,
            null);

        result.Should().Be((0, 0));
    }

    [Fact]
    public void TestMisplacedButMatchingColors()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Compare(
            new[] { PegColor.Yellow, PegColor.Blue },
            new[] { PegColor.Blue, PegColor.Yellow });

        result.Should().Be((0, 2));
    }

    [Fact]
    public void TestMisplacedButMatchingColors()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Compare(
            new[] { PegColor.Yellow, PegColor.Blue },
            new[] { PegColor.Yellow });

        result.Should().Be((1, 0));
    }
}
