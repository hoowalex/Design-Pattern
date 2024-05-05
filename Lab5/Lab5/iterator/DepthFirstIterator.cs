using lightHtml;

namespace iterator
{
    public class DepthFirstIterator : ILightNodeIterator
    {
        private Stack<LightNode> stack = new Stack<LightNode>();

        public DepthFirstIterator(LightNode root)
        {
            stack.Push(root);
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No such element");
            }

            LightNode current = stack.Pop();
            if (current is LightElementNode)
            {
                List<LightNode> children = ((LightElementNode)current).Children;
                for (int i = children.Count - 1; i >= 0; i--)
                {
                    stack.Push(children[i]);
                }
            }

            return current;
        }
    }
}