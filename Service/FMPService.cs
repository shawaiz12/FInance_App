using Finance_app.Interfaces;
using Finance_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Finance_app.DTOs.Stock;
using Finance_app.Mappers;

namespace Finance_app.Service
{
    public class FMPService : IFMPServince
    {
        private HttpClient _httpClient;
        private IConfiguration _config;

        public FMPService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }
        public async Task<Stock> FindStockBySymbolAsync(string symbol)
        {
            try
            {
                var result = await _httpClient.GetAsync($"https://financialmodelingprep.com/api/v3/profile/{symbol}?apikey={_config["FMPKey"]}");
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var tasks= JsonSerializer.Deserialize<FMPStock[]>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    var stock = tasks[0];
                    if(stock != null)
                    {
                        return stock.ToStockFromFMP();
                    }
                    return null;
                }

            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return null;
        }

     
    }
}
