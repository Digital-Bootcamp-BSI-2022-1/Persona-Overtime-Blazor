using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PersonaOvertimeWeb.Data;
using PersonaOvertimeWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddHttpClient<IUserDetailService, UserDetailService>(client =>
{
    client.BaseAddress = new Uri("https://persona-overtime.herokuapp.com");
});
builder.Services.AddHttpClient<IOvertimeService, OvertimeService>(client =>
{
    client.BaseAddress = new Uri("https://persona-overtime.herokuapp.com");
});

builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
