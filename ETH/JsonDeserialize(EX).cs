//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ETH
//{
//    internal class Json
//    {
//        static async Task Main(string[] args)
//        {
//            string url = "https://api.kucoin.com/api/v1/market/stats?symbol=ETH-USDT";

//            using var httpClient = new HttpClient();
//            using var response = await httpClient.GetAsync(url);
//            using var content = response.Content;

//            string json = await content.ReadAsStringAsync();

//            var data = JsonConvert.DeserializeObject(json);

//            Console.WriteLine(data);
//        }
//    }
//}
