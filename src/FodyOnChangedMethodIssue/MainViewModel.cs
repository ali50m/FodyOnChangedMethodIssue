using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FodyOnChangedMethodIssue;

internal partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private int _input;

    [ObservableProperty]
    private string _output = "0";

    partial void OnInputChanged(int value)
    {
        if (Random.Shared.Next(10) > 5)
        {
            throw new InvalidOperationException();
        }
        Output = $"{value}";
    }
}
