namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void EvaluateSingleCorrectGuess()
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
    public void EvaluateCombinationOfCorrectAndOneMisplacedGuesse()
    {
        var mastermind = new Mastermind();
        var secret = new[]
        {
            PegColor.Yellow,
            PegColor.Red,
            PegColor.Blue
        };
        var guess = new[]
        {
            PegColor.Yellow,
            PegColor.Blue,
            PegColor.Green
        };

        var result = mastermind.EvaluateGuess(
            guess,
            secret);

        result.Should().Be((1, 1));
    }

    [Fact]
    public void EvaluateCombinationOfCorrectAndTwoMisplacedGuesses()
    {
        var mastermind = new Mastermind();
        var secret = new[]
        {
            PegColor.Yellow,
            PegColor.Red,
            PegColor.Blue
        };
        var guess = new[]
        {
            PegColor.Yellow,
            PegColor.Blue,
            PegColor.Yellow
        };

        var result = mastermind.EvaluateGuess(
            guess,
            secret);

        result.Should().Be((1, 1));
    }

    [Fact]
    public void EvaluateCombinationOfTwoCorrectAndOneMisplacedGuesses()
    {
        var mastermind = new Mastermind();
        var secret = new[]
        {
            PegColor.Yellow,
            PegColor.Red,
            PegColor.Blue
        };
        var guess = new[]
        {
            PegColor.Yellow,
            PegColor.Blue,
            PegColor.Blue
        };

        var result = mastermind.EvaluateGuess(
            guess,
            secret);

        result.Should().Be((2, 0));
    }

    [Fact]
    public void EvaluateCombinationOfTwoCorrectAndNoneMisplacedGuesses()
    {
        var mastermind = new Mastermind();
        var secret = new[]
        {
            PegColor.Yellow,
            PegColor.Blue,
            PegColor.Red
        };
        var guess = new[]
        {
            PegColor.Yellow,
            PegColor.Blue,
            PegColor.Blue
        };

        var result = mastermind.EvaluateGuess(
            guess,
            secret);

        result.Should().Be((2, 0));
    }
    // Needed further tests
    //  - How do we handle double colors
    //  - Only misplaced guesses
}
