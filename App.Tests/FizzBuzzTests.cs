using System;
using mob_programming_dotnet;
using Xunit;

namespace App.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Given_3_When_Invoked_Then_Return_1_2_Fizz()
    {
        var result = FizzBuzz.Run(3);
        var expected = new string[] { "1", "2", "Fizz" };
        Assert.Equal(String.Join("\r\n", expected), result);
    }
}