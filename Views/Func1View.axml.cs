using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WinApp.Views;

public partial class Func1View : UserControl
{
    public Func1View()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}