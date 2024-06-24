using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thindal.Strings.Tests.ExtensionTests;
public class UntilTests
{
    [Fact]
    public void Until_WhenStringIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        var str = string.Empty;
        var until = "Hello";

        // Act
        var result = str.Until(until);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void Until_WhenUntilIsEmpty_ShouldReturnString()
    {
        // Arrange
        var str = "Hello";
        var until = string.Empty;

        // Act
        var result = str.Until(until);

        // Assert
        Assert.Equal(str, result);
    }

    [Fact]
    public void Until_WhenUntilIsNotInString_ShouldReturnString()
    {
        // Arrange
        var str = "Hello";
        var until = "World";

        // Act
        var result = str.Until(until);

        // Assert
        Assert.Equal(str, result);
    }

    [Fact]
    public void Until_WhenUntilIsInString_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello World";
        var until = " ";

        // Act
        var result = str.Until(until);

        // Assert
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void Until_WhenUntilIsInStringWithCaseSensitive_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello World";
        var until = "W";

        // Act
        var result = str.Until(until, StringComparison.Ordinal);

        // Assert
        Assert.Equal("Hello ", result);
    }

    [Fact]
    public void Until_WhenUntilIsInStringWithCaseInsensitive_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello World";
        var until = "w";

        // Act
        var result = str.Until(until, StringComparison.OrdinalIgnoreCase);

        // Assert
        Assert.Equal("Hello ", result);
    }

    [Fact]
    public void Until_WhenUntilIsInStringButOutsideIndexesWithStartIndexAndCount_ShouldReturnstring()
    {
        // Arrange
        var str = "Hello World";
        var until = " ";
        var startIndex = 6;
        var count = 5;

        // Act
        var result = str.Until(until, startIndex, count);

        // Assert
        Assert.Equal(str, result);
    }

    [Fact]
    public void Until_WhenUntilIsInStringWithStartIndexAndCountAndCaseSensitive_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello World";
        var until = "W";
        var startIndex = 6;
        var count = 5;

        // Act
        var result = str.Until(until, startIndex, count, StringComparison.Ordinal);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void Until_WhenUntilIsInStringWithStartIndexAndCountAndCaseInsensitive_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello World";
        var until = "w";
        var startIndex = 6;
        var count = 5;

        // Act
        var result = str.Until(until, startIndex, count, StringComparison.OrdinalIgnoreCase);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void Until_WhenUntilIsInStringWithStartIndexAndCaseSensitive_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello World";
        var until = "W";
        var startIndex = 6;

        // Act
        var result = str.Until(until, startIndex, StringComparison.Ordinal);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void Until_WhenUntilIsInStringWithStartIndexAndCaseInsensitive_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello World";
        var until = "w";
        var startIndex = 6;

        // Act
        var result = str.Until(until, startIndex, StringComparison.OrdinalIgnoreCase);

        // Assert
        Assert.Equal("", result);
    }
}
