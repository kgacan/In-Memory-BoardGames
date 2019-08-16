using BoardGame.Data;
using BoardGame.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoardGame.Service
{
    public class BoardGamesService : IBoardGames
    {
        private readonly BoardGamesDBContext _context;
        public BoardGamesService(BoardGamesDBContext db)
        {
            _context = db;
        }
        public void Add(Game game)
        {
            //Determine the next ID
            var newID = _context.BoardGames.Select(x => x.ID).Max() + 1;
            game.ID = newID;

            _context.BoardGames.Add(game);
            _context.SaveChanges();
        }

        public void Edit(Game game)
        {
            _context.BoardGames.Update(game);
            _context.SaveChanges();
        }

        public IEnumerable<Game> GetAll()
        {
            return _context.BoardGames;
        }

        public Game GetById(int id)
        {
            return _context.BoardGames.Find(id);
        }
    }
}
