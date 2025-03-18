using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog for logging
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog();

var app = builder.Build();

// Middleware to log each request
app.Use(async (context, next) =>
{
    Log.Information($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Log.Information($"Response: {context.Response.StatusCode}");
});

// Middleware to handle exceptions
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.ContentType = "text/html";
        await context.Response.WriteAsync("<h1>Something went wrong!</h1>");
    });
});

// Enforce HTTPS for security
app.UseHttpsRedirection();

// Middleware to serve static files
app.UseStaticFiles();

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello, welcome to Day8Ques3 Assignment 1!");
});

app.Run();
