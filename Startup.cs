using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

[assembly: FunctionsStartup(typeof(DITest.Startup))]


namespace DITest
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //throw new NotImplementedException();

            
            builder.Services.AddHttpClient<IHealthCheckClient,HealthCheckClient>()
                    .ConfigurePrimaryHttpMessageHandler(
                            x => new HttpClientHandler()
                            { MaxConnectionsPerServer = 22 }) ;
            builder.Services.AddTransient<IDependencyOne, DependencyOne>();
            builder.Services.AddTransient<IDependencyTwo, DependencyTwo>();

        }

    }
}
