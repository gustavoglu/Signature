using Signature.Presentation.Site.Client.States;
using Signature.Presentation.Site.Components;
using Signature.Shared.Interfaces;
using Signature.Presentation.Site.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddHttpClient("api", client => client.BaseAddress = new Uri("https://localhost:7051/api/"));

builder.Services.AddScoped<IBarCodeReadService, BarCodeService>();

builder.Services.AddSingleton<NotaFiscalState>();

builder.Services.AddSingleton<ICameraService, CameraService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Signature.Presentation.Site.Client._Imports).Assembly);

app.Run();
