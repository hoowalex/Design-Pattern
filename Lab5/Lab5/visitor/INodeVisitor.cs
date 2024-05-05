using lightHtml;

namespace visitor
{
    public interface INodeVisitor
    {
        void Visit(LightTextNode textNode);
        void Visit(LightElementNode elementNode);
    }
}