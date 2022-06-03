namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void ShouldHaveOneCorrectPlaced()
    {
        var guess = new[] { PinColor.Yellow };
        var secret = new[] { PinColor.Yellow };

        guess.Should().BeEquivalentTo(secret);
        (1,0).Should().Be((1, 0));

        "A,B,C".Split(",").Should().BeEquivalentTo(new[] { "A", "B", "C" });
    }

    [Fact]
    public void ShouldHaveNoneCorrectPlaced()
    {
        var guess = new[] { PinColor.Yellow };
        var secret = new[] { PinColor.Red };

        guess.Should().NotBeEquivalentTo(secret);
        (0,0).Should().Be((0, 0));

        "A,B,C".Split(",").Should().BeEquivalentTo(new[] { "A", "B", "C" });
    }

    [Fact]
    public void ShouldReturnEmptyTupleIfGuessISEmpty()
    {
        var guess = new PinColor[0];
        var secret = new[] { PinColor.Red };

        guess.Should().NotBeEquivalentTo(secret);
        (0,0).Should().Be((0, 0));

        "A,B,C".Split(",").Should().BeEquivalentTo(new[] { "A", "B", "C" });
    }

    [Fact]
    public void ShouldParseInput()
    {
        var parseResult = Parser.Parse(new string[]{"yellow,blue", "blue,red"});

        parseResult.Guess.Should().BeEquivalentTo(new[] { "yellow", "blue" });
        parseResult.Secret.Should().BeEquivalentTo(new[] { "blue", "red" });
    }


}
