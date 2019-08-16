using BoardGame.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame.Data
{
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoardGamesDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<BoardGamesDBContext>>()))
            {
                // Look for any board games.
                if (context.BoardGames.Any())
                {
                    return;   // Data was already seeded
                }

                context.BoardGames.AddRange(
                    new Game
                    {
                        ID = 1,
                        Title = "Candy Land",
                        PublishingCompany = "Hasbro",
                        MinPlayers = 2,
                        MaxPlayers = 4
                    },
                    new Game
                    {
                        ID = 2,
                        Title = "Sorry!",
                        PublishingCompany = "Hasbro",
                        MinPlayers = 2,
                        MaxPlayers = 4
                    },
                    new Game
                    {
                        ID = 3,
                        Title = "Ticket to Ride",
                        PublishingCompany = "Days of Wonder",
                        MinPlayers = 2,
                        MaxPlayers = 5
                    },
                    new Game
                    {
                        ID = 4,
                        Title = "The Settlers of Catan (Expanded)",
                        PublishingCompany = "Catan Studio",
                        MinPlayers = 2,
                        MaxPlayers = 6
                    },
                    new Game
                    {
                        ID = 5,
                        Title = "Carcasonne",
                        PublishingCompany = "Z-Man Games",
                        MinPlayers = 2,
                        MaxPlayers = 5
                    },
                    new Game
                    {
                        ID = 6,
                        Title = "Sequence",
                        PublishingCompany = "Jax Games",
                        MinPlayers = 2,
                        MaxPlayers = 6
                    });

                context.SaveChanges();
            }
        }
    }
}
