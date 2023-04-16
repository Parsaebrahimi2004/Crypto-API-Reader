using Newtonsoft.Json.Linq;

class KuCoin
{
    private readonly string _symbol;
    private decimal _lastPrice;

    public KuCoin(string symbol)
    {
        _symbol = symbol;
    }

    public async Task<decimal> CalculateAveragePrice()
    {
        List<decimal> prices = new List<decimal>();

        for (int i = 0; i < 24; i++)
        {
            HttpClient client = new HttpClient();
            string url = $"https://api.kucoin.com/api/v1/market/stats?symbol={_symbol}";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject json = JObject.Parse(responseBody);
            _lastPrice = (decimal)json["data"]["last"];
            prices.Add(_lastPrice);

            Console.WriteLine($"Last price for {_symbol} on KuCoin: ${_lastPrice} ({DateTime.Now})");

            await Task.Delay(TimeSpan.FromHours(1));// change the program timeframe by modifying this line and line 20 // 
        }

        decimal averagePrice = prices.Average();// Moving Average indicator // 
        return averagePrice;
    }

    public decimal GetLastPrice()
    {
        return _lastPrice;
    }
}


