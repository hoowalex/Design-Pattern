using lightHtml;

namespace state
{
    public class HiddenState : INodeState
    {
        public void Render(LightNode node)
        {
            Console.WriteLine("Node is hidden");
        }
    }
}
