namespace System;

public static class SubstringOrShorterExtensions
{
    /// <summary>
    /// Retrieves a substring from this instance. If the string is shorter than the length, the whole string is returned.
    /// </summary>
    /// <param name="length">The requested length of the string.</param>
    /// <returns>A string the length of <paramref name="length"/> or shorter.</returns>
    public static string SubstringOrShorter(this string str, int length)
    {
        if (str.Length <= length)
            return str;
        
        return str.Substring(0, length);
    }

    /// <summary>
    /// Retrieves a substring from this instance starting at <paramref name="startIndex"/>. If the string is shorter than the length, the whole string is returned.
    /// </summary>
    /// <param name="startIndex">The index to start the substring from</param>
    /// <param name="length">The requested length of the string</param>
    /// <returns>A string the length of <paramref name="length"/> or shorter, starting at <paramref name="startIndex"/></returns>
    public static string SubstringOrShorter(this string str, int startIndex, int length)
    {
        if (str.Length <= startIndex)
            return string.Empty;

        if (str.Length <= startIndex + length)
            return str.Substring(startIndex);

        return str.Substring(startIndex, length);
    }
}
