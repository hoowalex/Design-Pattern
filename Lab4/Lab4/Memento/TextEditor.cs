namespace memento
{
    public class TextEditor
    {
        private readonly TextDocument document;
        private readonly Stack<TextDocumentMemento> mementos = new Stack<TextDocumentMemento>();

        public TextEditor(string content)
        {
            document = new TextDocument(content);
        }

        public string GetContent()
        {
            return document.GetContent();
        }

        public void SetContent(string content)
        {
            document.SetContent(content);
        }

        public void Save()
        {
            mementos.Push(document.CreateMemento());
        }

        public void Undo()
        {
            if (mementos.Count > 0)
            {
                var memento = mementos.Pop();
                document.RestoreMemento(memento);
            }
            else
            {
                Console.WriteLine("Undo history is empty");
            }
        }
    }
}