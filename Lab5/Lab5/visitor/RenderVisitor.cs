using lightHtml;

namespace visitor
{
    public class RenderVisitor : INodeVisitor
    {
        public void Visit(LightTextNode textNode)
        {
            Console.WriteLine("Rendering text: " + textNode.OuterHtml());
        }

        public void Visit(LightElementNode elementNode)
        {
            Console.WriteLine("Rendering element: " + elementNode.OuterHtml());
        }
    }
}