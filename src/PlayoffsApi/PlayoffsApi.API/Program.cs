using PlayoffsApi.API.Configuration;
using PlayoffsApi.API.Configuration.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var hashIdSalt = builder.Configuration.GetSection("HashSalt").Value;

builder.Services.AddHashIds(hashIdSalt);
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