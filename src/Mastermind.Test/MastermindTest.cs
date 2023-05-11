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
    public void TestFourColors()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PinColor.Yellow, PinColor.Yellow, PinColor.Red, PinColor.Red }, new[] { PinColor.Pink, PinColor.Red, PinColor.Red, PinColor.Pink });

        result.Should().Be((1, 1));
    }
}
