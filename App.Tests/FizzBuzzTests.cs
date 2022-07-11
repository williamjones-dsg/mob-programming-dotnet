using mob_programming_dotnet;
using Xunit;

namespace App.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Should_Return()
    {
        var result = FizzBuzz.Run();
        Assert.NotEmpty(result);
    }
}