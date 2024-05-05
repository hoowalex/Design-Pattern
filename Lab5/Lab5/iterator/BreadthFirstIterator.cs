using lightHtml;
namespace iterator
{
    public class BreadthFirstIterator : ILightNodeIterator
    {
        private Queue<LightNode> queue = new Queue<LightNode>();

        public BreadthFirstIterator(LightNode root)
        {
            queue.Enqueue(root);
        }

        public bool HasNext()
        {
            return queue.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No such element");
            }

            LightNode current = queue.Dequeue();
            if (current is LightElementNode)
            {
                List<LightNode> children = ((LightElementNode)current).Children;
                foreach (LightNode child in children)
                {
                    queue.Enqueue(child);
                }
            }

            return current;
        }
    }
}