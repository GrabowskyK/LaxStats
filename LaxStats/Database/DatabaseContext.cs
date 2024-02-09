using LaxStats.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace LaxStats.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
        .HasOne(m => m.HomeTeam)
        .WithMany(t => t.HomeMatches)
        .HasForeignKey(m => m.HomeTeamId)
        .OnDelete(DeleteBehavior.Restrict); // Zmiana na NO ACTION

            modelBuilder.Entity<Match>()
                .HasOne(m => m.AwayTeam)
                .WithMany(t => t.AwayMatches)
                .HasForeignKey(m => m.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict); // Zmiana na NO ACTION
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches {  get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<TeamsInLeague> TeamsInLeagues { get; set; }
        public DbSet<EventPenalty> EventPenalties { get; set; }
        public DbSet<EventGoal> EventGoals{ get; set; }
    }
}
