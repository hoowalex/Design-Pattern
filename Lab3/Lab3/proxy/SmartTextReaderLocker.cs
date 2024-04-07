using System.Text.RegularExpressions;

namespace proxy
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private Regex filePattern;

        public SmartTextReaderLocker(string pattern)
        {
            filePattern = new Regex(pattern);
        }

        public new char[][] ReadTextFile(string filePath)
        {
            if (filePattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }
            else
            {
                return base.ReadTextFile(filePath);
            }
        }
    }
}