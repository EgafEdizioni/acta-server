using Microsoft.AspNetCore.Mvc.Testing;

namespace ActaServer.Tests;

public class StartupTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public StartupTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public void Application_StartsWithoutErrors()
    {
        // Se l'app non parte, WebApplicationFactory lancia eccezione
        using var client = _factory.CreateClient();
        Assert.NotNull(client);
    }
}
