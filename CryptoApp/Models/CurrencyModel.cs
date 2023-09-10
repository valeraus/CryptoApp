﻿namespace CryptoApp.Models
{
    class CurrencyModel
    {
        public string? Id { get; set; }
        public string? Ranc { get; set; }
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public string? Supply { get; set; }
        public string? MaxSupply { get; set; }
        public string? VolumeUsd24Hr { get; set; }
        public string? MarketCapUsd { get; set; }
        public string? PriceUsd { get; set; }
        public string? ChangePercent24Hr { get; set; }
        public string? Vwap24Hr { get; set; }
    }
}
