using ReactiveUI;

namespace ValueConversionSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    // The initial value is "+" (Add).
    private string _operator = "+";

    // The initial value is 2.
    private decimal? _number1 = 2;

    // The initial value is 3.
    private decimal? _number2 = 3;

    /// <summary>
    /// Gets a collection of available operators
    /// </summary>
    public string[] AvailableMathOperators { get; } = ["+", "-", "*", "/"];

    public string Operator
    {
        get { return _operator; }
        set { this.RaiseAndSetIfChanged(ref _operator, value); }
    }

    /// <summary>
    /// This is our Number 1
    /// </summary>
    public decimal? Number1
    { get { return _number1; } set { this.RaiseAndSetIfChanged(ref _number1, value); } }

    /// <summary>
    /// This is our Number 2
    /// </summary>
    public decimal? Number2
    { get { return _number2; } set { this.RaiseAndSetIfChanged(ref _number2, value); } }
}
