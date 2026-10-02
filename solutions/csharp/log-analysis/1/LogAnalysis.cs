public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string text, string sign)
    {
        int index = text.IndexOf(sign);
        return text.Substring(index + sign.Length);

    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string text, string start, string end)
    {
        int startIndex = text.IndexOf(start) + start.Length;
        int endIndex = text.IndexOf(end, startIndex);
        return text.Substring(startIndex, endIndex - startIndex);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string text)
    {
        return text.SubstringAfter("]: ");

    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string text)
    {
        return  text.SubstringBetween("[", "]");

    }
}