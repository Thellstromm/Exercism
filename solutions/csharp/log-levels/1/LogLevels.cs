static class LogLine
{
    public static string Message(string logLine)
    {
        int find = logLine.IndexOf(':');
        string message = logLine.Substring(find + 1).Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[');
        int end = logLine.IndexOf(']');
        string message = logLine.Substring(start + 1, end - start - 1).Trim().ToLower();
        return message;
    }

    public static string Reformat(string logLine)
    {
        int start = logLine.IndexOf('[');
        int end = logLine.IndexOf(']');
        int find = logLine.IndexOf(':');
        string message1 = logLine.Substring(find + 1).Trim();
        string message2 = logLine.Substring(start, end - start + 1).Trim().ToLower().Replace('[', '(').Replace(']', ')');
        return message1 + " " + message2;

    }
}
