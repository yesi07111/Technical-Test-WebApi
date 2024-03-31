
using FastEndpoints;
using FastEndpoints.Swagger;
using Infraestructure;
using WebApi;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddInfraestructure(builder.Configuration);
builder.Services.AddSecuritySchema(builder.Configuration);

builder.Services.AddFastEndpoints()
                .SwaggerDocument()
                .AddHealthChecks();

var app = builder.Build();


app.UseFastEndpoints(opt =>
{
    opt.Endpoints.RoutePrefix = "api";
});

app.UseCors("AllowLocalhost");

if (app.Environment.IsDevelopment())
    app.UseSwaggerGen();

app.Run();
