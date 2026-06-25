using DevPortfolio.Components;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Components with interactive server-side rendering.
// This is what lets components like the project filter and contact form
// run live C# in the browser without writing any JavaScript.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
