namespace adapter
{
    public interface IFileWriter
    {
        void Write(string text);
        void WriteLine(string text);
    }
}