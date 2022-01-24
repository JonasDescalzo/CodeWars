using DR.Data.Mysql.Activity.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Mysql.Activity
{
    public class ActivityContext : DbContext
    {
        public ActivityContext(DbContextOptions<ActivityContext> options)
  : base(options)
        {
           
        }

        public DbSet<PlatformConfig> PlatformConfig { get; set; }
        public DbSet<PlatformConfigSecondary> PlatformConfigSecondary { get; set; }

        public DbSet<PhoneSmsInfo> PhoneSmsInfo { get; set; }

        public DbSet<Setting> Setting { get; set; }

        public DbSet<BannerConfig> BannerConfig { get; set; }

        public DbSet<HotGame> HotGame { get; set; }

        public DbSet<SportsCategory> SportsCategory { get; set; }

        public DbSet<PromoConfig> PromoConfig { get; set; }

        public DbSet<ActivityTaskBonus> ActivityTaskBonus { get; set; }

        public DbSet<ActivityTaskPayout> ActivityTaskPayout { get; set; }

        public DbSet<Notice> Notice { get; set; }

        public DbSet<GameConfig> GameConfig { get; set; }

        public DbSet<PlatformGameAssocition> PlatformGameAssocition { get; set; }

        public DbSet<GameTypeAssocition> GameTypeAssocition { get; set; }

        public DbSet<LineGameAssocition> LineGameAssocition { get; set; }
        public DbSet<GameConfigIdependent> GameConfigIdependent { get; set; }

        public DbSet<PostComment> PostComment { get; set; }

    }
}
