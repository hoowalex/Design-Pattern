namespace lightHtml
{
    public class LightTextNode : LightNode
    {
        private string text;

        public LightTextNode(string text) : base("text", "self-closing", new List<string>())
        {
            this.text = text;
        }

        public override void Add(LightNode node)
        {
            throw new NotSupportedException("Cannot add child to text node");
        }

        public override void Remove(LightNode node)
        {
            throw new NotSupportedException("Cannot remove child from text node");
        }

        public override string OuterHtml()
        {
            return text;
        }

        public override string InnerHtml()
        {
            return text;
        }
    }
}