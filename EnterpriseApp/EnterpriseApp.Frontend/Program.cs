using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EnterpriseApp.Frontend;
using EnterpriseApp.Application.Services;  // Add this to use ProductService
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root components
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register the ProductService as a scoped service
builder.Services.AddScoped<ProductService>();

// Register HttpClient to make requests to the backend API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
