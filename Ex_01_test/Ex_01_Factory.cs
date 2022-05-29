using TO_DO.Context;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Ex_01_test
{
  public class Ex_01_Factory : WebApplicationFactory<Program>
  {
    protected override IHost CreateHost(IHostBuilder builder)
    {
      var root = new InMemoryDatabaseRoot();

      builder.ConfigureServices(services =>
      {
        services.AddScoped(sp =>
        {
          return new DbContextOptionsBuilder<SqlContext>()
              .UseInMemoryDatabase("Ex_01", root)
              .UseApplicationServiceProvider(sp).Options;
        });
      });

      return base.CreateHost(builder);
    }
  }
}