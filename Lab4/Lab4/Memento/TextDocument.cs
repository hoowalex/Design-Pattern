namespace memento
{
    public class TextDocument
    {
        private string content;

        public TextDocument(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(content);
        }

        public void RestoreMemento(TextDocumentMemento memento)
        {
            content = memento.GetContent();
        }
    }
}