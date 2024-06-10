public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        var words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}

class Program
{
    static void Main()
    {
        string[] testLines =
        {
            "Hello, world!",
            "This is a test line with several words.",
            "SingleWord",
            "",
            "     ",
            "Another\ttest\twith\ttabs",
            "New\nline\ncharacters\nare\nalso\nhandled.",
            "   Leading and trailing spaces are ignored   "
        };

        foreach (var line in testLines)
        {
            Console.WriteLine($"\"{line}\" has {line.WordCount()} words.");
        }
    }
}
