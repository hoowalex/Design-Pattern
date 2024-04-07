namespace adapter
{
    public class FileWriter : IFileWriter
    {
        private string filePath;

        public FileWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(string text)
        {
            File.WriteAllText(filePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(filePath, $"{text}{Environment.NewLine}");
        }
    }
}