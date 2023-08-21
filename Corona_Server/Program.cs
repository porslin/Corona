// main file of the application that creates or invokes the app
using Corona_Server.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

// we first have a createbuilder on the arguments here
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// building the app after registering all the services that bring the data
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // if app is not in dev mode it will show an error page
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    // creating an else block to create alternate scenario for dev mode where developer exception page shows instead of generic error page
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
// if it does not find anywhere to route, app will look for a _host page which isinside the pages folder
app.MapFallbackToPage("/_Host");

app.Run();
