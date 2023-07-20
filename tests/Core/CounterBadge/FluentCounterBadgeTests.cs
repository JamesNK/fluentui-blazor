using Bunit;
using Microsoft.AspNetCore.Components;
using Xunit;

namespace Microsoft.Fast.Components.FluentUI.Tests.CounterBadge;

public class FluentCounterBadgeTests : TestBase
{
    [Inject]
    public GlobalState GlobalState { get; set; } = default!;

    [Fact]
    public void FluentCounterBadge_AttributesDefaultValues()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCounterBadge>(parameters =>
        {
            parameters.Add(p => p.Count, 1);
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Theory]
    [InlineData(Appearance.Accent)]
    [InlineData(Appearance.Lightweight)]
    [InlineData(Appearance.Neutral)]
    public void FluentCoubterBadge_AppearanceAttribute(Appearance appearance)
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCounterBadge>(parameters =>
        {
            parameters.Add(p => p.Appearance, appearance);
            parameters.Add(p => p.Count, 1);
            parameters.AddChildContent("fluent-button");
        });

        // Assert
        cut.Verify(suffix: appearance.ToString());
    }


    [Fact]
    public void FluentCounterBadge_WithAdditionalCssClass()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCounterBadge>(parameters =>
        {
            parameters.Add(p => p.Class, "additional_class");
            parameters.Add(p => p.Count, 10);
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCounterBadge_WithAdditionalStyle()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCounterBadge>(parameters =>
        {
            parameters.Add(p => p.Style, "background-color: red");
            parameters.Add(p => p.Count, 10);
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCounterBadge_ShowOverflowAttribute()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCounterBadge>(parameters =>
        {
            parameters.Add(p => p.ShowOverflow, true);
            parameters.Add(p => p.Max, 9);
            parameters.Add(p => p.Count, 10);
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCounterBadge_BackgroundColorAndColorAttribute()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCounterBadge>(parameters =>
        {
            parameters.Add(p => p.BackgroundColor, Color.Accent);
            parameters.Add(p => p.Color, Color.Fill);
            parameters.Add(p => p.Count, 1);
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

    [Fact]
    public void FluentCounterBadge_ShowZeroAttribute()
    {
        // Arrange && Act
        var cut = TestContext.RenderComponent<FluentCounterBadge>(parameters =>
        {
            parameters.Add(p => p.ShowZero, true);
            parameters.Add(p => p.Count, 10);
            parameters.AddChildContent("childcontent");
        });

        // Assert
        cut.Verify();
    }

}
