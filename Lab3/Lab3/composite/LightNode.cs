namespace composite
{
    abstract class LightNode
    {
        protected string _tagName;
        protected string _displayType;
        protected string _closingType;
        protected List<string> _cssClasses;

        public LightNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            _tagName = tagName;
            _displayType = displayType;
            _closingType = closingType;
            _cssClasses = cssClasses;
        }

        public abstract void Add(LightNode node);
        public abstract void Remove(LightNode node);
        public abstract string OuterHtml();
        public abstract string InnerHtml();
    }
}
