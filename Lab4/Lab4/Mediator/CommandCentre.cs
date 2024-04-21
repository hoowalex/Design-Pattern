namespace mediator
{
    public class CommandCentre
{
    private List<Runway> runways = new List<Runway>();
    private List<Aircraft> aircrafts = new List<Aircraft>();

    public CommandCentre(List<Runway> runways, List<Aircraft> aircrafts)
    {
        this.runways = runways;
        this.aircrafts = aircrafts;
    }

    public void Notify(Colleague sender, string eventName)
    {
        if (eventName == "landing")
        {
            RequestLanding(sender as Aircraft);
        }
        else if (eventName == "takeoff")
        {
            RequestTakeOff(sender as Aircraft);
        }
    }

    public void RequestLanding(Aircraft aircraft)
    {
        var availableRunway = runways.Find(runway => !runway.IsBusy());
        if (availableRunway != null)
        {
            availableRunway.Land(aircraft);
        }
        else
        {
            Console.WriteLine("No available runway for landing.");
        }
    }

    public void RequestTakeOff(Aircraft aircraft)
    {
        var runway = aircraft.CurrentRunway;
        if (runway != null)
        {
            runway.TakeOff();
        }
        else
        {
            Console.WriteLine("Aircraft is not currently on any runway.");
        }
    }
}
    
}