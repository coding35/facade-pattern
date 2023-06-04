using System.Net;

namespace FacadePattern.SubsystemClasses;

// simple class to represent data operations.
public class Data
{
    public void Create(object data)
    {
        Console.WriteLine("Data created");
    }
    
    public object List()
    {
        Console.WriteLine("Data list read");
        return new object();
    }
    
    public object Read(int id)
    {
        Console.WriteLine("Data read");
        return new object();
    }

    public void Update(object data)
    {
        Console.WriteLine("Data updated");
    }
    
    public void Delete(int id)
    {
        Console.WriteLine("Data deleted");
    }
}