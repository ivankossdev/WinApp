# Программа WinApp

## Описание

Программа ничего не делает — только переключает компоненты окна.

## Структура проекта

```text
WinApp/
├── App.axaml
├── App.axaml.cs
├── app.manifest
├── Assets/
│   └── avalonia-logo.ico
├── bin/
│   └── Debug/
│       └── net10.0/
│           ├── Avalonia.*.dll (библиотеки Avalonia)
│           ├── CommunityToolkit.Mvvm.dll
│           ├── HarfBuzzSharp.dll
│           ├── MicroCom.Runtime.dll
│           ├── SkiaSharp.dll
│           ├── Tmds.DBus.Protocol.dll
│           ├── WinApp/
│           ├── WinApp.deps.json
│           ├── WinApp.dll
│           ├── WinApp.pdb
│           └── WinApp.runtimeconfig.json
├── Converters/
│   └── InverseBooleanConverter.cs
├── Models/
├── obj/
│   ├── Debug/
│   │   └── net10.0/ (промежуточные файлы сборки)
│   ├── project.assets.json
│   ├── project.nuget.cache
│   ├── WinApp.csproj.nuget.dgspec.json
│   ├── WinApp.csproj.nuget.g.props
│   └── WinApp.csproj.nuget.g.targets
├── Program.cs
├── Readme.md
├── run.sh
├── ViewLocator.cs
├── ViewModels/
│   ├── Func1ViewModel.cs
│   ├── Func2ViewModel.cs
│   ├── MainWindowViewModel.cs
│   └── ViewModelBase.cs
├── Views/
│   ├── Func1View.axaml
│   ├── Func1View.axaml.cs
│   ├── Func2View.axaml
│   ├── Func2View.axaml.cs
│   ├── MainWindow.axaml
│   └── MainWindow.axaml.cs
├── WinApp.csproj
└── WinApp.sln
