namespace mediator
{
    public class Runway : Colleague
    {
        public string Id { get; }
        public Aircraft? IsBusyWithAircraft { get; set; }

        public Runway(CommandCentre mediator) : base(mediator)
        {
            Id = Guid.NewGuid().ToString();
            IsBusyWithAircraft = null;
        }

        public bool IsBusy()
        {
            return IsBusyWithAircraft != null;
        }

        public void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is landing on Runway {Id}");
            IsBusyWithAircraft = aircraft;
            aircraft.CurrentRunway = this;
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {IsBusyWithAircraft.Name} is taking off from Runway {Id}");
            IsBusyWithAircraft = null;
        }
    }
}