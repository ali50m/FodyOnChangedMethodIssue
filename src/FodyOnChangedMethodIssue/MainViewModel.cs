using System;
using PropertyChanged;

namespace FodyOnChangedMethodIssue;

[AddINotifyPropertyChangedInterface]
internal class MainViewModel
{
    [OnChangedMethod(nameof(When_Input_Changed))]
    public int Input { get; set; }

    public string Output { get; private set; } = "0";

    private void When_Input_Changed()
    {
        if (Random.Shared.Next(10) > 5)
        {
            throw new InvalidOperationException();
        }

        Output = $"{Input}";
    }
}
