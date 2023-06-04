namespace FacadePattern.SubsystemClasses;

// simple class to represent formatting operations.
public class Formatter
{
    public object Format(object data)
    {
        Console.WriteLine("Data formatted");
        return new object();
    }
    
    public string Serialize(object data)
    {
        Console.WriteLine("Data serialized");
        return "";
    }
    
    public object Deserialize(string data)
    {
        Console.WriteLine("Data deserialized");
        return new object();
    }
}