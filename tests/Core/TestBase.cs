using Bunit;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Fast.Components.FluentUI.Tests;

public class TestBase
{
    protected readonly TestContext TestContext = new TestContext();

    public TestBase()
    {
        TestContext.Services.AddSingleton<GlobalState>();
    }
}