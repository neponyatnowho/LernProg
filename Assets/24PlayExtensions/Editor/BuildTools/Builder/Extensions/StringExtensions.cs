using System;
using System.Text.RegularExpressions;

public static partial class StringExtensions
{
    public static string RemoveNumbers(this string input)
    {
        string pattern = @"[\d-]";
        string replacement = string.Empty;
        Regex rgx = new Regex(pattern);
        string result = rgx.Replace(input, replacement);
        return result;
    }
}