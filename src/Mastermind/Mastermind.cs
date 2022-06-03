namespace CleanCode.Academy.MastermindDojo.Mastermind;

public class Mastermind
{

}

public class Parser
{
    public static (string[] Guess, string[] Secret) Parse(string[] args)
    {
        string[] guess = args[0].Split(',');
        string[] secret = args[1].Split(',');

        return (guess, secret);
    }

}


