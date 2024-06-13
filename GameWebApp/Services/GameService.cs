using GameWebApp.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace GameWebApp.Services
{
    public class GameService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public GameService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["RAWG:ApiKey"];
        }

        public async Task<IEnumerable<Game>> GetGamesAsync()
        {
            var response = await _httpClient.GetStringAsync($"https://api.rawg.io/api/games?key={_apiKey}");
            var data = JObject.Parse(response)["results"];
            return ParseGames(data);
        }

        public async Task<Game> GetGameDetailsAsync(int id)
        {
            var response = await _httpClient.GetStringAsync($"https://api.rawg.io/api/games/{id}?key={_apiKey}");
            var data = JObject.Parse(response);
            return await ParseGame(data);
        }

        public async Task<IEnumerable<Game>> GetNewReleasesAsync()
        {
            var response = await _httpClient.GetStringAsync($"https://api.rawg.io/api/games?dates=2023-05-01,2023-06-01&key={_apiKey}");
            var data = JObject.Parse(response)["results"];
            return ParseGames(data);
        }

        public async Task<IEnumerable<Game>> GetTopGamesAsync()
        {
            var response = await _httpClient.GetStringAsync($"https://api.rawg.io/api/games/lists/greatest?key={_apiKey}");
            var data = JObject.Parse(response)["results"];
            return ParseGames(data);
        }

        public async Task<IEnumerable<Game>> GetAllGamesAsync()
        {
            var response = await _httpClient.GetStringAsync($"https://api.rawg.io/api/games?key={_apiKey}");
            var data = JObject.Parse(response)["results"];
            return ParseGames(data);
        }

        private IEnumerable<Game> ParseGames(JToken data)
        {
            var games = new List<Game>();

            foreach (var item in data)
            {
                games.Add(new Game
                {
                    Id = (int)item["id"],
                    Name = (string)item["name"],
                    Description = (string)item["description"],
                    ImageUrl = (string)item["background_image"],
                    Rating = (string)item["rating"],
                    Platforms = string.Join(", ", item["platforms"].Select(p => (string)p["platform"]["name"])),
                    Stores = string.Join(", ", item["stores"].Select(s => (string)s["store"]["name"]))
                });
            }

            return games;
        }

        private async Task<Game> ParseGame(JToken data)
        {
            var game = new Game
            {
                Id = (int)data["id"],
                Name = (string)data["name"],
                Description = (string)data["description"],
                ImageUrl = (string)data["background_image"],
                Rating = (string)data["rating"],
                Platforms = string.Join(", ", data["platforms"].Select(p => (string)p["platform"]["name"])),
                Stores = string.Join(", ", data["stores"].Select(s => (string)s["store"]["name"])),
                Screenshots = await GetGameScreenshotsAsync((int)data["id"])
            };
            return game;
        }

        private async Task<IEnumerable<string>> GetGameScreenshotsAsync(int gameId)
        {
            var response = await _httpClient.GetStringAsync($"https://api.rawg.io/api/games/{gameId}/screenshots?key={_apiKey}");
            var data = JObject.Parse(response)["results"];
            return data.Select(s => (string)s["image"]).ToList();
        }
    }
}
