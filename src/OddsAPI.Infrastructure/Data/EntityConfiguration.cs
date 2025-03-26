using System;
using Microsoft.EntityFrameworkCore;
using OddsAPI.Core.Entities;

namespace OddsAPI.Infrastructure.Data;

public static class EntityConfiguration
{
    public static void SeedInitialEntities(ModelBuilder modelBuilder)
    {
        var now = DateTime.UtcNow;

        // Sports
        var sports = new[]
        {
            new Entity { Id = Guid.NewGuid(), Name = "Basketball", Type = "Sport", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Tennis", Type = "Sport", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Football", Type = "Sport", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Rugby Union", Type = "Sport", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "American Football", Type = "Sport", CreatedAt = now, UpdatedAt = now, IsActive = true }
        };

        // Teams (excluding Tennis)
        var teams = new[]
        {
            // Basketball Teams
            new Entity { Id = Guid.NewGuid(), Name = "Los Angeles Lakers", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Golden State Warriors", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Boston Celtics", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Chicago Bulls", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Miami Heat", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },

            // Football Teams
            new Entity { Id = Guid.NewGuid(), Name = "Manchester United", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Real Madrid", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Barcelona", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Bayern Munich", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Liverpool", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },

            // Rugby Union Teams
            new Entity { Id = Guid.NewGuid(), Name = "New Zealand", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "South Africa", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "England", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Ireland", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "France", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },

            // American Football Teams
            new Entity { Id = Guid.NewGuid(), Name = "Kansas City Chiefs", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "San Francisco 49ers", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Dallas Cowboys", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Green Bay Packers", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "New England Patriots", Type = "Team", CreatedAt = now, UpdatedAt = now, IsActive = true }
        };

        // Players
        var players = new[]
        {
            // Basketball Players
            new Entity { Id = Guid.NewGuid(), Name = "LeBron James", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Stephen Curry", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Kevin Durant", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Giannis Antetokounmpo", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Nikola Jokić", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },

            // Tennis Players
            new Entity { Id = Guid.NewGuid(), Name = "Novak Djokovic", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Carlos Alcaraz", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Daniil Medvedev", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Jannik Sinner", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Alexander Zverev", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },

            // Football Players
            new Entity { Id = Guid.NewGuid(), Name = "Erling Haaland", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Kylian Mbappé", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Jude Bellingham", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Vinicius Jr", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Kevin De Bruyne", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },

            // Rugby Union Players
            new Entity { Id = Guid.NewGuid(), Name = "Antoine Dupont", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Ardie Savea", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Eben Etzebeth", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Maro Itoje", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Caelan Doris", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },

            // American Football Players
            new Entity { Id = Guid.NewGuid(), Name = "Patrick Mahomes", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Brock Purdy", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Christian McCaffrey", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Myles Garrett", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true },
            new Entity { Id = Guid.NewGuid(), Name = "Justin Jefferson", Type = "Player", CreatedAt = now, UpdatedAt = now, IsActive = true }
        };

        modelBuilder.Entity<Entity>().HasData(sports);
        modelBuilder.Entity<Entity>().HasData(teams);
        modelBuilder.Entity<Entity>().HasData(players);
    }
} 