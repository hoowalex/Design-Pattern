namespace composite
{
    class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text) : base(null, null, null, null)
        {
            _text = text;
        }

        public override void Add(LightNode node)
        {
            throw new InvalidOperationException("Cannot add child to text node");
        }

        public override void Remove(LightNode node)
        {
            throw new InvalidOperationException("Cannot remove child from text node");
        }

        public override string OuterHtml()
        {
            return _text;
        }

        public override string InnerHtml()
        {
            return _text;
        }
    }
}