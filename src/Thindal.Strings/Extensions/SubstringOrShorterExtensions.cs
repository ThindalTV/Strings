namespace System;

public static class SubstringOrShorterExtensions
{
    public static string SubstringOrShorter(this string str, int length)
    {
        if (str.Length <= length)
            return str;
        
        return str.Substring(0, length);
    }

    public static string SubstringOrShorter(this string str, int startIndex, int length)
    {
        if (str.Length <= startIndex)
            return string.Empty;

        if (str.Length <= startIndex + length)
            return str.Substring(startIndex);

        return str.Substring(startIndex, length);
    }
}
