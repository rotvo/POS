

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;

namespace POS.Test
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(configurationBuilder =>
            {
                var integrationConfiguration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
                builder.UseSetting("ConnectionStrings:conexionSql", "Server=host.docker.internal;Database=db_floreria2;User Id=sa;Password=Root1234;TrustServerCertificate=True;Encrypt=False;MultipleActiveResultSets=True");


                configurationBuilder.AddConfiguration(integrationConfiguration);
            });
        }
    }
}
