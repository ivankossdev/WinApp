using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WinApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    // Инициализация компонентов Функционал Режима 1
    public Func1ViewModel Func1VM {get; } = new();

    // Инициализация компонентов Функционал Режима 2
    public Func2ViewModel Func2VM {get; } = new();

    [ObservableProperty]
    private object _currentContent;


    public MainWindowViewModel()
    {
        // Изначально показываем первый режим
        CurrentContent = Func1VM;
    }

    // Обработчик кнопки Режим 1
    [RelayCommand]
    private void ShowFunc1() => CurrentContent = Func1VM;

    // Обработчик кнопки Режим 2
    [RelayCommand]
    private void ShowFunc2() => CurrentContent = Func2VM;
}
