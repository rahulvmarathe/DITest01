using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DITest
{

    public interface IHealthCheckClient
    {
        Task<String> GetStatusAsync();

        HttpClient Client { get; }
    }

    public class HealthCheckClient : IHealthCheckClient
    {
        private readonly HttpClient _client;

        public HealthCheckClient(HttpClient client)
        {
            _client = client;
        }

        public Task<String> GetStatusAsync()
        {
            return _client.GetStringAsync("/");
        }

        public HttpClient Client { 
            
            get { return _client; }
        
        }
    }
}
