using CryptoApp.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace CryptoApp.ViewModels
{
    class MainViewModel
    {
        public ObservableCollection<CurrencyModel> Currencies { get; set; }
        public MainViewModel()
        {
            Currencies = new ObservableCollection<CurrencyModel>();
            LoadData();
        }
        private async void LoadData()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("https://api.coincap.io/v2/assets?limit=10");
            var data = JsonConvert.DeserializeObject<CoinCapResponse>(response);

            foreach (var currency in data.Data)
            {
                Currencies.Add(currency);
            }
        }
        public class CoinCapResponse
        {
            public CurrencyModel[] Data { get; set; }
        }
    }
}
