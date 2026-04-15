<h1>Программа WinApp</h1>
<p>
    <h2>Описание</h2>
    Программа ничего не делает только переключает компоненты окна. 
</p>
<p>
<h2>Структура проекта</h2>
```text
.
├── App.axaml
├── App.axaml.cs
├── app.manifest
├── Assets
│   └── avalonia-logo.ico
├── bin
│   └── Debug
│       └── net10.0
│           ├── Avalonia.Base.dll
│           ├── Avalonia.Controls.ColorPicker.dll
│           ├── Avalonia.Controls.dll
│           ├── Avalonia.DesignerSupport.dll
│           ├── Avalonia.Desktop.dll
│           ├── Avalonia.Diagnostics.dll
│           ├── Avalonia.Dialogs.dll
│           ├── Avalonia.dll
│           ├── Avalonia.Fonts.Inter.dll
│           ├── Avalonia.FreeDesktop.dll
│           ├── Avalonia.Markup.dll
│           ├── Avalonia.Markup.Xaml.dll
│           ├── Avalonia.Metal.dll
│           ├── Avalonia.MicroCom.dll
│           ├── Avalonia.Native.dll
│           ├── Avalonia.OpenGL.dll
│           ├── Avalonia.Remote.Protocol.dll
│           ├── Avalonia.Skia.dll
│           ├── Avalonia.Themes.Fluent.dll
│           ├── Avalonia.Themes.Simple.dll
│           ├── Avalonia.Vulkan.dll
│           ├── Avalonia.Win32.Automation.dll
│           ├── Avalonia.Win32.dll
│           ├── Avalonia.X11.dll
│           ├── CommunityToolkit.Mvvm.dll
│           ├── HarfBuzzSharp.dll
│           ├── MicroCom.Runtime.dll
│           ├── runtimes
│           │   ├── linux-arm
│           │   │   └── native
│           │   │       ├── libHarfBuzzSharp.so
│           │   │       └── libSkiaSharp.so
│           │   ├── linux-arm64
│           │   │   └── native
│           │   │       ├── libHarfBuzzSharp.so
│           │   │       └── libSkiaSharp.so
│           │   ├── linux-loongarch64
│           │   │   └── native
│           │   │       └── libHarfBuzzSharp.so
│           │   ├── linux-musl-arm
│           │   │   └── native
│           │   │       └── libHarfBuzzSharp.so
│           │   ├── linux-musl-arm64
│           │   │   └── native
│           │   │       └── libHarfBuzzSharp.so
│           │   ├── linux-musl-loongarch64
│           │   │   └── native
│           │   │       └── libHarfBuzzSharp.so
│           │   ├── linux-musl-riscv64
│           │   │   └── native
│           │   │       └── libHarfBuzzSharp.so
│           │   ├── linux-musl-x64
│           │   │   └── native
│           │   │       ├── libHarfBuzzSharp.so
│           │   │       └── libSkiaSharp.so
│           │   ├── linux-riscv64
│           │   │   └── native
│           │   │       └── libHarfBuzzSharp.so
│           │   ├── linux-x64
│           │   │   └── native
│           │   │       ├── libHarfBuzzSharp.so
│           │   │       └── libSkiaSharp.so
│           │   ├── linux-x86
│           │   │   └── native
│           │   │       └── libHarfBuzzSharp.so
│           │   ├── osx
│           │   │   └── native
│           │   │       ├── libAvaloniaNative.dylib
│           │   │       ├── libHarfBuzzSharp.dylib
│           │   │       └── libSkiaSharp.dylib
│           │   ├── win-arm64
│           │   │   └── native
│           │   │       ├── av_libglesv2.dll
│           │   │       ├── libHarfBuzzSharp.dll
│           │   │       └── libSkiaSharp.dll
│           │   ├── win-x64
│           │   │   └── native
│           │   │       ├── av_libglesv2.dll
│           │   │       ├── libHarfBuzzSharp.dll
│           │   │       └── libSkiaSharp.dll
│           │   └── win-x86
│           │       └── native
│           │           ├── av_libglesv2.dll
│           │           ├── libHarfBuzzSharp.dll
│           │           └── libSkiaSharp.dll
│           ├── SkiaSharp.dll
│           ├── Tmds.DBus.Protocol.dll
│           ├── WinApp
│           ├── WinApp.deps.json
│           ├── WinApp.dll
│           ├── WinApp.pdb
│           └── WinApp.runtimeconfig.json
├── Converters
│   └── InverseBooleanConverter.cs
├── Models
├── obj
│   ├── Debug
│   │   └── net10.0
│   │       ├── apphost
│   │       ├── Avalonia
│   │       │   ├── references
│   │       │   ├── resources
│   │       │   └── Resources.Inputs.cache
│   │       ├── ref
│   │       │   └── WinApp.dll
│   │       ├── refint
│   │       │   └── WinApp.dll
│   │       ├── WinApp.AssemblyInfo.cs
│   │       ├── WinApp.AssemblyInfoInputs.cache
│   │       ├── WinApp.assets.cache
│   │       ├── WinApp.csproj.AssemblyReference.cache
│   │       ├── WinApp.csproj.CoreCompileInputs.cache
│   │       ├── WinApp.csproj.FileListAbsolute.txt
│   │       ├── WinApp.csproj.Up2Date
│   │       ├── WinApp.dll
│   │       ├── WinApp.GeneratedMSBuildEditorConfig.editorconfig
│   │       ├── WinApp.genruntimeconfig.cache
│   │       ├── WinApp.pdb
│   │       └── WinApp.sourcelink.json
│   ├── project.assets.json
│   ├── project.nuget.cache
│   ├── WinApp.csproj.nuget.dgspec.json
│   ├── WinApp.csproj.nuget.g.props
│   └── WinApp.csproj.nuget.g.targets
├── Program.cs
├── Readme.md
├── run.sh
├── ViewLocator.cs
├── ViewModels
│   ├── Func1ViewModel.cs
│   ├── Func2ViewModel.cs
│   ├── MainWindowViewModel.cs
│   └── ViewModelBase.cs
├── Views
│   ├── Func1View.axaml
│   ├── Func1View.axml.cs
│   ├── Func2View.axaml
│   ├── Func2View.axml.cs
│   ├── MainWindow.axaml
│   └── MainWindow.axaml.cs
├── WinApp.csproj
└── WinApp.sln
</p>