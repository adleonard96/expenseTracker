public class ArgumentHandler(IArgumentHandlerFactory factory)
{
    public IArgumentHandlerFactory Factory = factory;

    public Dictionary<string, object>  HandleArguments(List<string> args)
    {
        return Factory.HandleArgs(args);
    }
}