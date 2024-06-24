using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thindal.Strings.Tests.ExtensionTests;
public class SubstringOrShorterTests
{
    [Fact]
    public void SubstringOrShorter_WhenStringIsShorterThanLength_ShouldReturnString()
    {
        // Arrange
        var str = "Hello";
        var length = 10;

        // Act
        var result = str.SubstringOrShorter(length);

        // Assert
        Assert.Equal(str, result);
    }

    [Fact]
    public void SubstringOrShorter_WhenStringIsLongerThanLength_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello";
        var length = 3;

        // Act
        var result = str.SubstringOrShorter(length);

        // Assert
        Assert.Equal("Hel", result);
    }

    [Fact]
    public void SubstringOrShorter_WhenStringIsShorterThanStartIndex_ShouldReturnEmptyString()
    {
        // Arrange
        var str = "Hello";
        var startIndex = 10;
        var length = 3;

        // Act
        var result = str.SubstringOrShorter(startIndex, length);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void SubstringOrShorter_WhenStringIsLongerThanStartIndexAndLength_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello";
        var startIndex = 1;
        var length = 3;

        // Act
        var result = str.SubstringOrShorter(startIndex, length);

        // Assert
        Assert.Equal("ell", result);
    }

    [Fact]
    public void SubstringOrShorter_WhenStringIsLongerThanStartIndexAndShorterThanLength_ShouldReturnSubstring()
    {
        // Arrange
        var str = "Hello";
        var startIndex = 1;
        var length = 10;

        // Act
        var result = str.SubstringOrShorter(startIndex, length);

        // Assert
        Assert.Equal("ello", result);
    }
}
