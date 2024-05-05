using lightHtml;
using iterator;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", "open", new List<string> { "container" });

        LightElementNode paragraph = new LightElementNode("p", "open", new List<string>());
        LightTextNode text = new LightTextNode("Hello, World!");
        paragraph.Add(text);

        div.Add(paragraph);


        LightElementNode span = new LightElementNode("span", "open", new List<string>());
        LightTextNode spanText = new LightTextNode("This is a span");
        span.Add(spanText);

        div.Add(span);

        Console.WriteLine("Outer HTML of div:");
        Console.WriteLine(div.OuterHtml());

        div.Remove(span);

        Console.WriteLine("Outer HTML of div after removal:");
        Console.WriteLine(div.OuterHtml());


        //iterator
        LightElementNode div2 = new LightElementNode("div", "open", new List<string> { "container" });

        LightElementNode p = new LightElementNode("p", "open", new List<string>());
        LightTextNode text2 = new LightTextNode("Hello, World!");
        p.Add(text2);

        LightElementNode span2 = new LightElementNode("span", "open", new List<string>());
        LightTextNode spanText2 = new LightTextNode("This is a span");
        span2.Add(spanText2);

        div2.Add(p);
        div2.Add(span2);

        Console.WriteLine("Depth-First Traversal:");
        ILightNodeIterator dfsIterator = new DepthFirstIterator(div2);
        while (dfsIterator.HasNext())
        {
            LightNode node = dfsIterator.Next();
            Console.WriteLine(node.OuterHtml());
        }

    }

}


