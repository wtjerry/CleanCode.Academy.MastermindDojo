namespace CleanCode.Academy.MastermindDojo.Mastermind.Test;

using FluentAssertions;
using Xunit;

public class MastermindTest
{
    [Fact]
    public void EinePositionUndFarbeRichtig_Gibt_1_0()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PegColor.Yellow }, new[] { PegColor.Yellow });

        result.Should().Be((1, 0));
    }

    [Fact]
    public void KeinePosition_KeineFarbeRichtig_Gibt_0_0()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PegColor.Yellow }, new[] { PegColor.Blue });

        result.Should().Be((0, 0));
    }

    [Fact]
    public void TestYellowGreen()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[] { PegColor.Yellow, PegColor.Green, PegColor.Pink }, new[] { PegColor.Yellow, PegColor.Blue, PegColor.Green });

        result.Should().Be((1, 1));
    }

    [Fact]
    public void DreiPinsNurEinerStimmtExakt_Gibt_1_0()
    {
        var mastermind = new Mastermind();
        var result = mastermind.Do(new[]
        {
            PegColor.Yellow, PegColor.Yellow, PegColor.Yellow
        }, new[] { PegColor.Blue, PegColor.Blue, PegColor.Yellow });

        result.Should().Be((1, 0));
    }

}
