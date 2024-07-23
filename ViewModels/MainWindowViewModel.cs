using ReactiveUI;

namespace ValueConversionSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    // The initial value is 2.
    private decimal? _number1 = 2;

    /// <summary>
    /// This is our Number 1
    /// </summary>
    public decimal? Number1
    { get { return _number1; } set { this.RaiseAndSetIfChanged(ref _number1, value); } }
}
