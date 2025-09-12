using EventPlanner;
using EventPlanner.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Services (in-memory)
builder.Services.AddScoped<IEventService, InMemoryEventService>();
builder.Services.AddScoped<IRegistrationService, InMemoryRegistrationService>();

await builder.Build().RunAsync();

