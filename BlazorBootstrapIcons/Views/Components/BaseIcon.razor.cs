using Microsoft.AspNetCore.Components;

namespace BlazorBootstrapIcons.Views.Components;

public partial class BaseIcon
{
    private string path;

    public BaseIcon(string source) => path = $"images/bootstrap-icons/bootstrap-icons.svg#{source}";

    [Parameter]
    public int Size { get; set; } = 24;

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> UncapturedAttributes { get; set; }
}
