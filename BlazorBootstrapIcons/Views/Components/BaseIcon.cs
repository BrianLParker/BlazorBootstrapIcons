using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorBootstrapIcons.Views.Components;

public abstract class BaseIcon : ComponentBase
{
    [Parameter]
    public int Size { get; set; } = 24;

    protected abstract string IconSource { get; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var source = $"_content/BlazorBootstrapIcons/images/bootstrap-icons/bootstrap-icons.svg#{IconSource}";

        builder.OpenElement(sequence: 1, elementName: "svg");
        builder.AddAttribute(sequence: 2, name: "class", value: "bi");
        builder.AddAttribute(sequence: 3, name: "width", value: Size);
        builder.AddAttribute(sequence: 4, name: "height", value: Size);
        builder.AddAttribute(sequence: 5, name: "fill", value: "currentColor");

            builder.OpenElement(sequence: 6, elementName: "use");
            builder.AddAttribute(sequence: 7, name: "href", value: source);
            builder.CloseElement();

        builder.CloseElement();
    }
}
