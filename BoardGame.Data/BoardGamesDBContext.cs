using Microsoft.EntityFrameworkCore;
using BoardGame.Data.Model;
using System;

namespace BoardGame.Data
{
 
    public class BoardGamesDBContext : DbContext
    {
        public BoardGamesDBContext(DbContextOptions<BoardGamesDBContext> options)
            : base(options)
        {
        }

        public DbSet<Game> BoardGames { get; set; }
    }
}
