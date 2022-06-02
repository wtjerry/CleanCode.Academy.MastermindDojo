namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void TestSuccessMatch()
    {
        var mastermind = new Mastermind();
        var result = mastermind.guess(new[] { PinColor.Yellow }, new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void TestFailUnmatched()
    {
        var mastermind = new Mastermind();
        var result = mastermind.guess(new[] { PinColor.Yellow }, new[] { PinColor.Red });

        result.Should().Be((0, 0));
    }

    [Fact]
    public void TestFailMissplaced()
    {
        var mastermind = new Mastermind();
        var result = mastermind.guess(new[] { PinColor.Yellow, PinColor.Blue }, new[] { PinColor.Red, PinColor.Yellow });

        result.Should().Be((0, 1));
    }

    [Fact]
    public void TestOneMatchedOneMisplaced()
    {
        var mastermind = new Mastermind();
        var result = mastermind.guess(new[] { PinColor.Yellow, PinColor.Blue, PinColor.Pink }, new[] { PinColor.Yellow, PinColor.Yellow, PinColor.Blue });

        result.Should().Be((1, 1));
    }


    [Fact]
    public void ShouldReturnAnEmptyTupleIfTheSecretArrayIsNull()
    {
        var mastermind = new Mastermind();
        var result = mastermind.guess(null, new[] { PinColor.Yellow, PinColor.Yellow, PinColor.Blue });

        result.Should().Be((0, 0));
    }
}
