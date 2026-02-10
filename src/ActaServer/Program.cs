var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "healthy", service = "acta-server" }));
app.MapGet("/", () => Results.Ok(new { service = "ActaServer", version = "0.1.0-stub" }));
app.MapGet("/api/info", () => Results.Ok(new { service = "ActaServer", version = "0.1.0-stub", environment = "test" }));

app.Run();

public partial class Program { }
