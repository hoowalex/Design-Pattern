namespace flyweight
{
    public static class TextHelper
    {
        public static List<string> SplitTextIntoLines(string text)
        {
            return new List<string>(text.Split('\n'));
        }

        public static string DetermineElementType(string line)
        {
            if (line.Length < 20)
            {
                return "h2";
            }
            else if (line.StartsWith(" "))
            {
                return "blockquote";
            }
            else
            {
                return "p";
            }
        }
    }
}