using adapter;
using decorator;
using bridge;
using proxy;
using composite;
using flyweight;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Adapter
        var logger = new Logger();
        var fileLogger = new Adapter(logger);

        fileLogger.Write("Message");
        Console.WriteLine(" ");
        fileLogger.WriteLine("Message");

        Console.WriteLine("\nLogs was added.");


        //Decorator
        Hero warrior = new Warrior();
        Hero mage = new Mage();
        Hero paladin = new Paladin();

        warrior = new ClothingDecorator(warrior);
        warrior = new WeaponDecorator(warrior);
        warrior = new ArtifactDecorator(warrior);

        mage = new WeaponDecorator(mage);
        mage = new ArtifactDecorator(mage);

        paladin = new ClothingDecorator(paladin);
        paladin = new ArtifactDecorator(paladin);

        warrior.Display();
        warrior.Attack();

        mage.Display();
        mage.Attack();

        paladin.Display();
        paladin.Attack();



        //Bridge
        // VectorDraw
        Console.WriteLine();
        IDraw vectorDrawAPI = new VectorDraw();
        Shape circle = new Circle(vectorDrawAPI);
        Shape square = new Square(vectorDrawAPI);
        Shape triangle = new Triangle(vectorDrawAPI);

        circle.Draw();
        square.Draw();
        triangle.Draw();

        Console.WriteLine();

        // RasterDraw

        IDraw rasterDrawAPI = new RasterDraw();
        circle = new Circle(rasterDrawAPI);
        square = new Square(rasterDrawAPI);
        triangle = new Triangle(rasterDrawAPI);

        circle.Draw();
        square.Draw();
        triangle.Draw();


        //Proxy
        Console.WriteLine();
        string filePath = "example.txt";

        SmartTextReader reader = new SmartTextReader();
        char[][] text = reader.ReadTextFile(filePath);
        Console.WriteLine("Text content:");
        foreach (char[] line in text)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine();

        SmartTextChecker checker = new SmartTextChecker();
        char[][] checkedText = checker.ReadTextFile(filePath);

        SmartTextReaderLocker locker = new SmartTextReaderLocker(@"restricted.*");
        char[][] restrictedText = locker.ReadTextFile(filePath);


        //Composite
        Console.WriteLine();
        LightElementNode body = new LightElementNode("body", "block", "open",
            new List<string>(),
            new List<LightNode>()
            {
                new LightElementNode("h1", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Hello, LightHTML!")} ),
                new LightElementNode("ul", "block", "open", new List<string>(),
                    new List<LightNode>()
                    {
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 1")} ),
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 2")} ),
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 3")} ),
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 4")} )
                    }
                )
            }
        );

        Console.WriteLine(body.OuterHtml());


        //Flyweight
        string bookText;
        using (WebClient client = new())
        {
            bookText = client.DownloadString("https://www.gutenberg.org/cache/epub/1513/pg1513.txt");
        }
        List<string> lines = TextHelper.SplitTextIntoLines(bookText);
        List<LightHtmlElement> htmlElements = new List<LightHtmlElement>();

        foreach (string line in lines)
        {
            string elementType = TextHelper.DetermineElementType(line);
            LightHtmlElement element = new LightHtmlElement(elementType, line.Trim());
            htmlElements.Add(element);
        }

        string htmlMarkup = string.Join("\n", htmlElements);

        int totalSizeInMemory = 0;
        foreach (var element in htmlElements)
        {
            totalSizeInMemory += element.CalculateSizeInMemory();
        }

        Console.WriteLine(htmlMarkup);
        Console.WriteLine($"Size in process memory for the entire layout tree: {totalSizeInMemory} bytes");

    }
}
