namespace proxy
{
    public class SmartTextChecker : SmartTextReader
    {
        public new char[][] ReadTextFile(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");
            char[][] result = base.ReadTextFile(filePath);
            Console.WriteLine($"File {filePath} has been read. Total lines: {result.Length}, total characters: {GetTotalCharacters(result)}");
            return result;
        }

        private int GetTotalCharacters(char[][] lines)
        {
            int total = 0;
            foreach (char[] line in lines)
            {
                total += line.Length;
            }
            return total;
        }
    }
}