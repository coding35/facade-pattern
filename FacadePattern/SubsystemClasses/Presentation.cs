namespace FacadePattern.SubsystemClasses;

public class Presentation
{
    public ViewModel Display(object data)
    {
        Console.WriteLine("Data displayed");
        return new ViewModel();
    }
    
    public ViewModel DisplayList(object data)
    {
        Console.WriteLine("Data list displayed");
        return new ViewModel();
    }
}