namespace flyweight
{
    public class LightHtmlElement
    {
        private string tag;
        private string content;

        public LightHtmlElement(string tag, string content)
        {
            this.tag = tag;
            this.content = content;
        }

        // Легковаговик на класах HTML елементів
        public int CalculateSizeInMemory() => sizeof(char) * (tag.Length + content.Length);

        public override string ToString()
        {
            return $"<{tag}>{content}</{tag}>";
        }
    }
}