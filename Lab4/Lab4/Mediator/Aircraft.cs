namespace mediator
{
    public class Aircraft : Colleague
{
    public string Name { get; }
    public Runway? CurrentRunway { get; set; }
    public bool IsTakingOff { get; set; }

    public Aircraft(CommandCentre mediator, string name) : base(mediator)
    {
        this.Name = name;
        this.CurrentRunway = null;
        this.IsTakingOff = false;
    }

    public void Send(string eventName)
    {
        mediator.Notify(this, eventName);
    }
}
}