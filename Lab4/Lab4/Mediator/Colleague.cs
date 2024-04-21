namespace mediator
{
    public class Colleague
{
    protected CommandCentre mediator;

    public Colleague(CommandCentre mediator)
    {
        this.mediator = mediator;
    }
}
}