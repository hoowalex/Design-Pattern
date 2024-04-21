namespace memento
{
    public class TextDocumentMemento
    {
        private readonly string content;

        public TextDocumentMemento(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }

}