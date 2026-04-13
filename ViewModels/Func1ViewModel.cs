using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace WinApp.ViewModels;

public partial class Func1ViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title = "Функционал Режима 1";
}