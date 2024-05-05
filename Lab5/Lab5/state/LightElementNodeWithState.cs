using lightHtml;

namespace state
{
    public class LightElementNodeWithState : LightNode
    {
        private INodeState currentState;
        private List<LightNode> children = new List<LightNode>();

        public LightElementNodeWithState(string tagName, string closingType, List<string> cssClasses) : base(tagName, closingType, cssClasses)
        {
            this.currentState = new VisibleState();
        }

        public void SetState(INodeState newState)
        {
            this.currentState = newState;
        }

        public void Render()
        {
            currentState.Render(this);
        }

        public override void Add(LightNode node)
        {
            children.Add(node);
        }

        public override void Remove(LightNode node)
        {
            children.Remove(node);
        }

        public override string OuterHtml()
        {
            var builder = new System.Text.StringBuilder();
            builder.Append("<").Append(tagName);

            if (cssClasses != null)
            {
                builder.Append(" class=\"").Append(string.Join(" ", cssClasses)).Append("\"");
            }

            builder.Append(">");

            if ("open".Equals(closingType))
            {
                builder.Append(InnerHtml());
            }

            builder.Append("</").Append(tagName).Append(">");
            return builder.ToString();
        }

        public override string InnerHtml()
        {
            var builder = new System.Text.StringBuilder();
            foreach (var child in children)
            {
                builder.Append(child.OuterHtml());
            }
            return builder.ToString();
        }
    }
}