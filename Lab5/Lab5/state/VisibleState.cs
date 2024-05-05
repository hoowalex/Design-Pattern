using lightHtml;

namespace state
{
    public class VisibleState : INodeState
    {
        public void Render(LightNode node)
        {
            Console.WriteLine("Rendering node: " + node.OuterHtml());
        }
    }
}