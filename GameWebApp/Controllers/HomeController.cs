using GameWebApp.Models;
using GameWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameService _gameService;

        public HomeController(GameService gameService)
        {
            _gameService = gameService;
        }

        public async Task<IActionResult> Index()
        {
            var games = await _gameService.GetGamesAsync();
            return View(games);
        }

        public async Task<IActionResult> Details(int id)
        {
            var game = await _gameService.GetGameDetailsAsync(id);
            return View(game);
        }

        public async Task<IActionResult> NewReleases()
        {
            var games = await _gameService.GetNewReleasesAsync();
            return View(games);
        }

        public async Task<IActionResult> Top()
        {
            var games = await _gameService.GetTopGamesAsync();
            return View(games);
        }

        public async Task<IActionResult> AllGames()
        {
            var games = await _gameService.GetAllGamesAsync();
            return View(games);
        }
    }
}
