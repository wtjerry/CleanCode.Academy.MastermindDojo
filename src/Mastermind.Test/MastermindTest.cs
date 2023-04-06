namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void Test1()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PinColor.Yellow }, new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void Test2()
    {
        var mastermind = new Mastermind();
        var result =
            mastermind.Do(new[]
                { PinColor.Yellow, PinColor.Blue },
                new[] { PinColor.Yellow, PinColor.Green });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void Test3()
    {
        var mastermind = new Mastermind();
        var result =
            mastermind.Do(new[]
                    { PinColor.Yellow, PinColor.Yellow },
                new[] { PinColor.Yellow, PinColor.Green });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void TestOneMisplaced()
    {
        var mastermind = new Mastermind();
        var result =
            mastermind.Do(new[]
                    { PinColor.Green, PinColor.Blue },
                new[] { PinColor.Yellow, PinColor.Green });

        result.Should().Be((0, 1));
    }

    [Fact]
    public void TesteWellPlacedOnly()
    {
        var mastermind = new Mastermind();
        var result =
            mastermind.Do(new[]
                    { PinColor.Yellow, PinColor.Blue},
                new[] { PinColor.Yellow, PinColor.Purple });

        result.Should().Be((1, 0));
    }

    public void TesteOnO()
    {
        var mastermind = new Mastermind();
        var result =
            mastermind.Do(new[]
                    { PinColor.Yellow, PinColor.Blue},
                new[] { PinColor.Yellow, PinColor.Purple });

        result.Should().Be((1, 0));
    }
}
