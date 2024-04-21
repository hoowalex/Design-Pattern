using chain_of_responsibility;
using mediator;
using observer;
using strategy;
using memento;

class Program
{
    static void Main(string[] args)
    {
        //Chain of Responsibility
        SupportSystem supportSystem = new SupportSystem();
        string response;
        do
        {
            int level;
            do
            {
                Console.Write("Choose the level of support (1-10): ");
            } while (!int.TryParse(Console.ReadLine(), out level));

            supportSystem.HandleRequest(level);

            Console.Write("\nWould you like to continue? (y/n): ");
            response = Console.ReadLine();
        } while (response.ToLower() == "y");


        //Mediator
        Console.WriteLine();
        var runway1 = new Runway(null);
        var runway2 = new Runway(null);
        var runways = new List<Runway> { runway1, runway2 };

        var aircraft1 = new Aircraft(null, "Boeing 777");
        var aircraft2 = new Aircraft(null, "Airbus A321");
        var aircrafts = new List<Aircraft> { aircraft1, aircraft2 };

        var commandCentre = new CommandCentre(runways, aircrafts);

        commandCentre.Notify(aircraft1, "landing");
        commandCentre.Notify(aircraft2, "landing");
        commandCentre.Notify(aircraft1, "takeoff");
        commandCentre.Notify(aircraft2, "takeoff");


        //Observer
        Console.WriteLine();
        var button = new LightElementNode("button", "inline", "double", new List<string> { "btn" }, new List<LightNode>());
        button.AddEventListener("click", () =>
        {
            Console.WriteLine("Button clicked!");
        });
        Console.WriteLine(button.OuterHTML());
        button.TriggerEvent("click");


        // Strategy
        Console.WriteLine();
        // Loading from the file system
        var fileImage = new Image(new FileImageLoadingStrategy());
        fileImage.Load("path/to/image.jpg");

        // Loading from the network
        var networkImage = new Image(new NetworkImageLoadingStrategy());
        networkImage.Load("http://test.com/image.jpg");


        //Memento
        Console.WriteLine();
        var editor = new TextEditor("Initial content");

        editor.Save();
        editor.SetContent("Modified content");
        editor.Undo();

        Console.WriteLine(editor.GetContent());

        editor.SetContent("Modified content");
        editor.Save();

        Console.WriteLine(editor.GetContent());

    }
}