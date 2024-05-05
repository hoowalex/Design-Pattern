namespace lightHtml
{
    public abstract class LightNode
    {
        protected string tagName;
        protected string closingType;
        protected List<string> cssClasses;

        public LightNode(string tagName, string closingType, List<string> cssClasses)
        {
            this.tagName = tagName;
            this.closingType = closingType;
            this.cssClasses = cssClasses;
            OnCreated();
        }

        protected void OnCreated()
        {
            Console.WriteLine("Node created: " + tagName);
        }

        protected virtual void OnInserted(LightNode node)
        {
            Console.WriteLine("Node inserted into " + tagName + ": " + node.tagName);
        }

        protected virtual void OnRemoved(LightNode node)
        {
            Console.WriteLine("Node removed from " + tagName + ": " + node.tagName);
        }

        protected void OnStylesApplied()
        {
            Console.WriteLine("Styles applied to: " + tagName);
        }

        protected void OnClassListApplied()
        {
            Console.WriteLine("Class list applied to: " + tagName);
        }

        protected void OnTextRendered()
        {
            Console.WriteLine("Class list applied to: " + tagName);
        }

        public abstract void Add(LightNode node);

        public abstract void Remove(LightNode node);

        public abstract string OuterHtml();

        public abstract string InnerHtml();

    }
}
