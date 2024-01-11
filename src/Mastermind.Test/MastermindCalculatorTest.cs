namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindCalculatorTest
{
    [Fact]
    public void Test1()
    {
        var mastermind = new MastermindCalculator();
        var result = mastermind.Do(new[] { PinColor.Yellow }, new[] { PinColor.Yellow });

        result.Should().Be((1, 0));
    }
}
