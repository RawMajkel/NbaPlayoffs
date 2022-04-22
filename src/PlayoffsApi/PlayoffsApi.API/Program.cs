using PlayoffsApi.API.Configuration.Endpoints;
using PlayoffsApi.API.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointDefinitions(typeof(IEndpointDefinition));
builder.Services.AddMediatR();

var app = builder.Build();

app.UseEndpointDefinitions();
app.UseHttpsRedirection();
app.Run();