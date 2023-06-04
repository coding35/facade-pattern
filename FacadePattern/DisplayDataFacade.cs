using FacadePattern.SubsystemClasses;

namespace FacadePattern;

// over simplified example of a facade class.
public class DisplayDataFacade
{
    private readonly Data _data;
    private readonly Formatter _formatter;
    private readonly Presentation _presentation;

    public DisplayDataFacade(Data data, Formatter formatter, Presentation presentation)
    {
        _data = data;
        _formatter = formatter;
        _presentation = presentation;
    }
    
    public ViewModel RenderAllData()
    {
        var data = _data.List();
        var formatted = _formatter.Format(data);
        var vm = _presentation.DisplayList(formatted);
        return vm;
    }
}

public class ViewModel
{
    public object ViewData { get; set; }
}