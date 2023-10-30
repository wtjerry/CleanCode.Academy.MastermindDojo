namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void TestEinKorrekterPlatz()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(new[] { PinColor.Yellow }, new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void TestZweiKorrektePlaetze()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(new[] { PinColor.Yellow, PinColor.Blue }, new[] { PinColor.Yellow, PinColor.Blue });

        result.Should().Be((2, 0));
    }

    [Fact]
    public void Test2KorrektePlaetzeUndZweiKorrekteFarben()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(
            new[] { PinColor.Yellow, PinColor.Blue, PinColor.Blue, PinColor.Green },
            new[] { PinColor.Yellow, PinColor.Blue, PinColor.Green, PinColor.Blue }
        );

        result.Should().Be((2, 2));
    }

    [Fact]
    public void Test2KorrekteFarben()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(
            new[] { PinColor.Purple, PinColor.Purple, PinColor.Blue, PinColor.Green },
            new[] { PinColor.Green, PinColor.Blue, PinColor.Red, PinColor.Red }
        );

        result.Should().Be((0, 2));
    }

    [Fact]
    public void Test3KorrekteFarben()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(
            new[] { PinColor.Purple, PinColor.Purple, PinColor.Blue, PinColor.Green },
            new[] { PinColor.Green, PinColor.Blue, PinColor.Red, PinColor.Purple }
        );

        result.Should().Be((0, 3));
    }

    [Fact]
    public void Test3KorrekteFarben2()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(
            new[] { PinColor.Purple, PinColor.Red, PinColor.Blue, PinColor.Green },
            new[] { PinColor.Green, PinColor.Blue, PinColor.Purple, PinColor.Purple }
        );

        result.Should().Be((0, 3));
    }

    [Fact]
    public void Test3KorrekteFarben3()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(
            new[] { PinColor.Green, PinColor.Blue, PinColor.Purple, PinColor.Purple },
            new[] { PinColor.Purple, PinColor.Red, PinColor.Blue, PinColor.Green }
        );

        result.Should().Be((0, 3));
    }


    [Fact]
    public void TestAllesFalsch()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Evaluate(
            new[] { PinColor.Purple },
            new[] { PinColor.Green }
        );

        result.Should().Be((0, 0));
    }


}
