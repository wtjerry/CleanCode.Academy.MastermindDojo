namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void EvaluateSingleGuess()
    {
        var mastermind = new Mastermind();
        var result = mastermind.EvaluateGuess(
            new[] { PegColor.Yellow },
            new[] { PegColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void EvaluateForMisplacedGuesses()
    {
        var mastermind = new Mastermind();
        var secret = new[]
        {
            PegColor.Yellow,
            PegColor.Red
        };
        var guess = new[]
        {
            PegColor.Red,
            PegColor.Yellow
        };

        var result = mastermind.EvaluateGuess(
            guess,
            secret);

        result.Should().Be((0, 2));
    }

    [Fact]
    public void Test3()
    {
        var mastermind = new Mastermind();
        var secret = new[]
        {
            PegColor.Yellow,
            PegColor.Red
        };
        var guess = new[]
        {
            PegColor.Red,
            PegColor.Yellow
        };

        var result = mastermind.EvaluateGuess(
            guess,
            secret);

        result.Should().Be((0, 2));
    }



}
