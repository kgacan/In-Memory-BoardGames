using System;
using System.Collections.Generic;
using System.Text;
using BoardGame.Data.Model;

namespace BoardGame.Data
{
    public interface IBoardGames
    {
        IEnumerable<Game> GetAll();
        Game GetById(int id);
        void Add(Game game);
        void Edit(Game game);

    }
}
