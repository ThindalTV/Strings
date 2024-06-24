namespace System;
public static class UntilExtensions
{
    public static string Until(this string str, string until)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    public static string Until(string str, int startIndex, string until)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index-startIndex);
    }

    // indexof char
    public static string Until(this string str, char until)
    {
        var index = str.IndexOf(until);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    // indexof char, startindex
    public static string Until(this string str, char until, int startIndex)
    {
        var index = str.IndexOf(until, startIndex);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index-startIndex);
    }

    // indexof char, startindex, count
    public static string Until(this string str, char until, int startIndex, int count)
    {
        var index = str.IndexOf(until, startIndex, count);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index-startIndex);
    }

    // indexof char, StringComparison
    public static string Until(this string str, char until, StringComparison comparisonType)
    {
        var index = str.IndexOf(until, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    // indexof string, StringComparison
    public static string Until(this string str, string until, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(0, index);
    }

    // indexof string, startindex, count, StringComparison
    public static string Until(this string str, string until, int startIndex, int count, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex, count, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index-startIndex);
    }

    // indexof string, startindex, count
    public static string Until(this string str, string until, int startIndex, int count)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex, count);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index-startIndex);
    }

    // indexof string, startindex, StringComparison
    public static string Until(this string str, string until, int startIndex, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(until))
            return str;

        var index = str.IndexOf(until, startIndex, comparisonType);
        if (index == -1)
            return str;

        return str.Substring(startIndex, index-startIndex);
    }

}
