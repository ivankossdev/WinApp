using Microsoft.VisualBasic;

namespace WinApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public Func1ViewModel Func1VM {get; } = new();
    public Func2ViewModel Func2VM {get; } = new();
}
