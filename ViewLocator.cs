using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using WinApp.ViewModels;

namespace WinApp;

/// <summary>
/// Given a view model, returns the corresponding view if possible.
/// </summary>
[RequiresUnreferencedCode(
    "Default implementation of ViewLocator involves reflection which may be trimmed away.",
    Url = "https://docs.avaloniaui.net/docs/concepts/view-locator")]
public class ViewLocator : IDataTemplate
{
    // Кэшируем сопоставления ViewModel → View для ускорения
    private static readonly ConcurrentDictionary<Type, Type?> _viewTypeCache = new();

    public Control? Build(object? param)
    {
        if (param is null)
            return null;

        var viewModelType = param.GetType();
        
        // Получаем тип View из кэша или вычисляем
        if (!_viewTypeCache.TryGetValue(viewModelType, out var viewType))
        {
            viewType = FindViewType(viewModelType);
            _viewTypeCache.TryAdd(viewModelType, viewType);
        }

        if (viewType != null)
        {
            return (Control)Activator.CreateInstance(viewType)!;
        }
        
        // Детальное сообщение об ошибке
        var assemblyName = viewModelType.Assembly.GetName().Name;
        return new TextBlock
        { 
            Text = $"View not found for {viewModelType.Name}. Searched in assembly: {assemblyName}"
        };
    }

    private Type? FindViewType(Type viewModelType)
    {
        // Безопасное получение FullName
        var viewModelFullName = viewModelType.FullName;
        if (string.IsNullOrEmpty(viewModelFullName))
        {
            Console.WriteLine($"Cannot resolve view: ViewModel has no FullName: {viewModelType}");
            return null;
        }

        // Формируем имя View с заменой и указанием сборки
        var viewName = viewModelFullName.Replace("ViewModel", "View", StringComparison.Ordinal);
        var assemblyName = viewModelType.Assembly.GetName().Name;
        var fullViewName = $"{viewName}, {assemblyName}";

        var type = Type.GetType(fullViewName);
        if (type == null)
        {
            // Дополнительная попытка: ищем без указания сборки (на случай, если сборка другая)
            type = Type.GetType(viewName);
        }

        return type;
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}
