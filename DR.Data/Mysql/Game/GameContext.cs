using DR.Data.Mysql.Game.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mysql.Game
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)  
  : base(options)
        {
            
        }

        public DbSet<ControlSessionToken> ControlSessionToken { get; set; }

        public DbSet<LogSchedule> LogSchedule { get; set; }

    }
}
