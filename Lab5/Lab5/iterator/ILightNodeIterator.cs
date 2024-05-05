using lightHtml;

namespace iterator
{
    public interface ILightNodeIterator
    {
        bool HasNext();
        LightNode Next();
    }
}
