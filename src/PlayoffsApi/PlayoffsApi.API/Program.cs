using PlayoffsApi.API.Configuration.Endpoints;
using PlayoffsApi.API.Configuration;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddPostgreSQL(connectionString);
builder.Services.AddMediatR();
builder.Services.AddAutoMapper();

builder.Services.AddEndpointDefinitions(typeof(IEndpointDefinition));
builder.Services.AddGraphQL();

var app = builder.Build();

app.UseEndpointDefinitions();
app.MapGraphQL();
app.UseHttpsRedirection();
app.Run();