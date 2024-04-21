namespace chain_of_responsibility
{
    class SupportSystem
{
    private SupportHandler headHandler;

    public SupportSystem()
    {

        headHandler = new LowLevelHandler();
        LowLevelHandler lowlevelHandler = new LowLevelHandler();
        AverageLevelHandler averagelevelHandler = new AverageLevelHandler();
        HighLevelHandler highLevelHandler= new HighLevelHandler();
        ExtremeLevelHandler extremeLevelHandler= new ExtremeLevelHandler();

        headHandler.SetNextHandler(lowlevelHandler);
        lowlevelHandler.SetNextHandler(averagelevelHandler);
        averagelevelHandler.SetNextHandler(highLevelHandler);
        highLevelHandler.SetNextHandler(extremeLevelHandler);

    }

    public void HandleRequest(int level)
    {
        headHandler.HandleRequest(level);
    }
}
}