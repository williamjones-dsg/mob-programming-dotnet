using System;
using mob_programming_dotnet;
using Xunit;

namespace App.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Given_3_When_Invoked_Then_Return_1_2_Fizz()
    {
        var lines = new string[] { "1", "2", "Fizz" };
        var expected = String.Join("\r\n", lines);
        var result = FizzBuzz.Run(3);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Given_five_when_invoked_then_return_buzz()
    {
        var lines = new string[] { "1", "2", "Fizz", "4", "Buzz" };
        var expected = String.Join("\r\n", lines);
        var result = FizzBuzz.Run(5);
        Assert.Equal(expected, result);
    }
}