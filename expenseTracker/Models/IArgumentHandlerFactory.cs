public interface IArgumentHandlerFactory 
{
    public Dictionary<string, object> HandleArgs(List<string> arguments);
}