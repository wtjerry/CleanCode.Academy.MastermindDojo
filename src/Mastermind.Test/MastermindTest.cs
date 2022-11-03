namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using System;
using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void Test1()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Yellow },
            new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void Test2()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Red, PinColor.Green },
            new[] { PinColor.Yellow, PinColor.Green });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void WhenSpecifyUnmatchingGuessItShouldBe0()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Yellow, PinColor.Red },
            new[] { PinColor.Green, PinColor.Blue });

        result.Should().Be((1, 0));
    }

    [Theory]
    [InlineData(
        new[] { PinColor.Yellow, PinColor.Red },
        new[] { PinColor.Yellow, PinColor.Red },
        1,
        0)]

    public void Test4(
        PinColor[] secret,
        PinColor[] guess,
        int a,
        int b)
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Red, PinColor.Green },
            new[] { PinColor.Yellow, PinColor.Green });

        result.Should().Be((1, 0));
    }
}
