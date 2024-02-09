namespace LaxStats.Models
{
    public class TeamsInLeague
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }

        public TeamsInLeague() { } 
        public TeamsInLeague(Team team, League league)
        {
            Team = team;
            League = league;
        }
    }
}
