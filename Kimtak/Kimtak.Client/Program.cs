using Kimtak.Client.Presenter;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Kimtak.Client.Extension;
using Microsoft.Fast.Components.FluentUI;

namespace Kimtak.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddFluentUIComponents();
            builder.Services.AddPresenters();

            await builder.Build().RunAsync();
        }   
    }
}
