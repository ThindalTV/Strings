namespace System;
/// <summary>
/// Provides extension methods for the <see cref="string"/> class to extract substrings until a specified delimiter.
/// </summary>
public static class UntilExtensions
{
    /// <summary>
    /// Returns a substring from the start of the input string until the first occurrence of the specified delimiter.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter string.</param>
    /// <returns>The substring until the first occurrence of the delimiter, or the original string if the delimiter is not found.</returns>
    public static string Until(this string str, string until)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    /// <summary>
    /// Returns a substring from the specified start index of the input string until the first occurrence of the specified delimiter.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="startIndex">The start index of the substring.</param>
    /// <param name="until">The delimiter string.</param>
    /// <returns>The substring until the first occurrence of the delimiter, or the original string if the delimiter is not found.</returns>
    public static string Until(string str, int startIndex, string until)
    {
        // TODO: Needs tests
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index - startIndex);
    }

    /// <summary>
    /// Returns a substring from the start of the input string until the first occurrence of the specified character.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter character.</param>
    /// <returns>The substring until the first occurrence of the character, or the original string if the character is not found.</returns>
    public static string Until(this string str, char until)
    {
        // TODO: Needs tests
        var index = str.IndexOf(until);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    /// <summary>
    /// Returns a substring from the specified start index of the input string until the first occurrence of the specified character.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter character.</param>
    /// <param name="startIndex">The start index of the substring.</param>
    /// <returns>The substring until the first occurrence of the character, or the original string if the character is not found.</returns>
    public static string Until(this string str, char until, int startIndex)
    {
        // TODO: Needs tests
        var index = str.IndexOf(until, startIndex);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index - startIndex);
    }

    /// <summary>
    /// Returns a substring from the specified start index of the input string until the first occurrence of the specified character within the specified count.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter character.</param>
    /// <param name="startIndex">The start index of the substring.</param>
    /// <param name="count">The maximum number of characters to consider.</param>
    /// <returns>The substring until the first occurrence of the character, or the original string if the character is not found.</returns>
    public static string Until(this string str, char until, int startIndex, int count)
    {
        // TODO: Needs tests
        var index = str.IndexOf(until, startIndex, count);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index - startIndex);
    }

    /// <summary>
    /// Returns a substring from the start of the input string until the first occurrence of the specified character using the specified comparison type.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter character.</param>
    /// <param name="comparisonType">The comparison type to use.</param>
    /// <returns>The substring until the first occurrence of the character, or the original string if the character is not found.</returns>
    public static string Until(this string str, char until, StringComparison comparisonType)
    {
        // TODO: Needs tests
        var index = str.IndexOf(until, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    /// <summary>
    /// Returns a substring from the start of the input string until the first occurrence of the specified delimiter using the specified comparison type.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter string.</param>
    /// <param name="comparisonType">The comparison type to use.</param>
    /// <returns>The substring until the first occurrence of the delimiter, or the original string if the delimiter is not found.</returns>
    public static string Until(this string str, string until, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    /// <summary>
    /// Returns a substring from the specified start index of the input string until the first occurrence of the specified delimiter using the specified comparison type within the specified count.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter string.</param>
    /// <param name="startIndex">The start index of the substring.</param>
    /// <param name="count">The maximum number of characters to consider.</param>
    /// <param name="comparisonType">The comparison type to use.</param>
    /// <returns>The substring until the first occurrence of the delimiter, or the original string if the delimiter is not found.</returns>
    public static string Until(this string str, string until, int startIndex, int count, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex, count, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index - startIndex);
    }

    /// <summary>
    /// Returns a substring from the specified start index of the input string until the first occurrence of the specified delimiter using the specified count.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter string.</param>
    /// <param name="startIndex">The start index of the substring.</param>
    /// <param name="count">The maximum number of characters to consider.</param>
    /// <returns>The substring until the first occurrence of the delimiter, or the original string if the delimiter is not found.</returns>
    public static string Until(this string str, string until, int startIndex, int count)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex, count);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index - startIndex);
    }

    /// <summary>
    /// Returns a substring from the specified start index of the input string until the first occurrence of the specified delimiter using the specified comparison type.
    /// </summary>
    /// <param name="str">The input string.</param>
    /// <param name="until">The delimiter string.</param>
    /// <param name="startIndex">The start index of the substring.</param>
    /// <param name="comparisonType">The comparison type to use.</param>
    /// <returns>The substring until the first occurrence of the delimiter, or the original string if the delimiter is not found.</returns>
    public static string Until(this string str, string until, int startIndex, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index - startIndex);
    }
}
