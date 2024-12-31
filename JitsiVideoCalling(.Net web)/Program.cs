using JitsiVideoCalling;
using Microsoft.Extensions.Logging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container
builder.Services.AddSignalR(); // Register SignalR services

// Define the manually created log directory
var logDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Logs");

// Ensure the log directory exists
if (!Directory.Exists(logDirectory))
{
    Directory.CreateDirectory(logDirectory); // Optional if the folder is manually created
}

// Set up Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(Path.Combine(logDirectory, "log-.txt"), rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//app.UseDefaultFiles();
app.UseCors("AllowAll");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapHub<VideoCallHub>("/VideoCallHub");
app.MapFallbackToFile("index.html");
app.Run();
