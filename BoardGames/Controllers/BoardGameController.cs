using System.Linq;
using BoardGame.Data;
using BoardGame.Data.Model;
using BoardGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardGame.Controllers
{
    public class BoardGamesController : Controller
    {
        private readonly IBoardGames _boardGames;

        public BoardGamesController(IBoardGames boardGames)
        {
            _boardGames = boardGames;
        }

        //...and can access it in our actions.
        [HttpGet]
        public IActionResult Index()
        {
            var games = _boardGames.GetAll().Select(x => new BoardGameVM
            {
                Title = x.Title,
                MaxPlayers = x.MaxPlayers,
                MinPlayers = x.MinPlayers,
                PublishingCompany = x.PublishingCompany
            }).ToList();

            return View(games);
        }


        [HttpPost]
        public IActionResult Add(Game game)
        {
            _boardGames.Add(game);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var game = _boardGames.GetById(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            _boardGames.Edit(game);

            return RedirectToAction("Index");
        }
    }
}