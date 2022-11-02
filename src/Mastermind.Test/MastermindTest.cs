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
        var result = mastermind.Do(new[] { PinColor.Yellow }, new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void Test2()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(
            new[] { PinColor.Yellow, PinColor.Red },
            new[] { PinColor.Yellow, PinColor.Blue });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void Test3()
    {
        var mastermind = new Mastermind();
        var f = () => mastermind.Do(new[] { PinColor.Yellow, PinColor.Red, PinColor.Green },
            new[] { PinColor.Yellow, PinColor.Blue });

        f.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Arrays do not have a matching size. (Parameter 'secret')");
    }

    [Fact]
    public void Test4()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PinColor.Yellow, PinColor.Red, PinColor.Green },
            new[] { PinColor.Yellow, PinColor.Green, PinColor.Red });

        result.Should().Be((1, 2));
    }

    [Fact]
    public void Test5()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PinColor.Red, PinColor.Yellow, PinColor.Green },
            new[] { PinColor.Yellow, PinColor.Green, PinColor.Red });

        result.Should().Be((0, 3));
    }

    [Fact]
    public void Test6()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PinColor.Red, PinColor.Yellow, PinColor.Green },
            new[] { PinColor.Red, PinColor.Yellow, PinColor.Green });

        result.Should().Be((3, 0));
    }

    [Fact]
    public void Test7()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PinColor.Red, PinColor.Yellow, PinColor.Green },
            new[] { PinColor.Blue, PinColor.Blue, PinColor.Blue });

        result.Should().Be((0, 0));
    }
}
