using System.Text;

namespace lightHtml
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> children = new List<LightNode>();

        public LightElementNode(string tagName, string closingType, List<string> cssClasses) : base(tagName, closingType, cssClasses)
        {
        }

        public override void Add(LightNode node)
        {
            children.Add(node);
            OnInserted(node);
        }

        public override void Remove(LightNode node)
        {
            if (node is LightElementNode)
            {
                children.Remove(node);
                OnRemoved(node);
            }
            else
            {
                throw new InvalidOperationException("Cannot remove non-element node from element node");
            }
        }


        public override string OuterHtml()
        {
            StringBuilder builder = new StringBuilder();
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
            OnStylesApplied();
            return builder.ToString();
        }

        public override string InnerHtml()
        {
            StringBuilder builder = new StringBuilder();
            foreach (LightNode child in children)
            {
                builder.Append(child.OuterHtml());
            }
            return builder.ToString();
        }

        protected virtual void OnInserted(LightNode node)
        {
            if (node is LightElementNode)
            {
                Console.WriteLine("Node inserted into " + tagName + ": " + ((LightElementNode)node).tagName);
            }
            else if (node is LightTextNode)
            {
                Console.WriteLine("Node inserted into " + tagName + ": " + ((LightTextNode)node).OuterHtml());
            }
        }


        protected override void OnRemoved(LightNode node)
        {
            Console.WriteLine("Node removed: " + ((LightElementNode)node).tagName);
        }
    }
}