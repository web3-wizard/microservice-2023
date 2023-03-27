using System.Text;
using System.Text.Json;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpclient;
        private readonly IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpclient, IConfiguration configuration)
        {
            _httpclient = httpclient;
            _configuration = configuration;
        }

        public async Task SendPlatformToCommand(PlatformReadDto plat)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,
                "application/json");
            
            var response = await _httpclient.PostAsync(_configuration["CommandService"], httpContent);

            if(response.IsSuccessStatusCode)
            {
                System.Console.WriteLine("--> Sync Post to CommandService is OK!");
            }
            else
            {
                System.Console.WriteLine("--> Sync Post to CommandService is Failed!");
            }
        }
    }
}