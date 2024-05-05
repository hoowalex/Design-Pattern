using lightHtml;
using System.Net;

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
    }

}


