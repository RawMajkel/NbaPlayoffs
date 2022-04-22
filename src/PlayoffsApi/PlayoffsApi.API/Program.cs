using PlayoffsApi.API.Configuration.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinitions(typeof(IEndpointDefinition));

var app = builder.Build();
app.UseEndpointDefinitions();

app.UseHttpsRedirection();
app.Run();