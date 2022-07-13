namespace mob_programming_dotnet;

public static class FizzBuzz
{
    public static string Run(int lines)
    {
        var output = "";
        for (var i = 1; i <= lines; i++)
        {
            output += FizzUtil.GetTextForLine(i);
            output += "\r\n";
        }

        return output.Trim();
    }
    
    
}

public static class FizzUtil
{
    public static string GetTextForLine(int lineNumber)
    {
        if (lineNumber % 3 == 0)
        {
            return "Fizz";
        }
        if (lineNumber % 5 == 0)
        {
            return "Buzz";
        }

        return lineNumber.ToString();
    }

    public static string GetTextForLines(int lines)
    {
        throw new NotImplementedException();
    }
}