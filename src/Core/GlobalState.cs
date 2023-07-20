namespace Microsoft.Fast.Components.FluentUI;

public class GlobalState
{
    public LocalizationDirection Dir { get; set; } = LocalizationDirection.ltr;
    public StandardLuminance Luminance { get; set; } = StandardLuminance.LightMode;

    public event Action? OnChange;

    public GlobalState()
    {
    }


    public GlobalState(StandardLuminance luminance)
    {
        Luminance = luminance;
    }

    public GlobalState(LocalizationDirection dir)
    {
        Dir = dir;
    }

    public GlobalState(StandardLuminance luminance, LocalizationDirection dir)
    {
        Luminance = luminance;
        Dir = dir;
    }

    public void SetDirection(LocalizationDirection dir)
    {
        Dir = dir;
        NotifyStateHasChanged();
    }

    public void SetLuminance(StandardLuminance luminance)
    {
        Luminance = luminance;
        NotifyStateHasChanged();
    }

    private void NotifyStateHasChanged()
    {
        OnChange?.Invoke();
    }
}
