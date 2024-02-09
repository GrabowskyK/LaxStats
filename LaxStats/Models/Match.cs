namespace LaxStats.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public DateTime DateTime { get; set; }
        public int ScoreHomeTeam { get; set; } = 0;
        public int ScoreAwayTeam { get; set; } = 0;
        public string Place { get; set; }
        public bool IsEnded { get; set; } = false;
        public int LeagueId { get; set; }
        public League League { get; set; }

        public ICollection<EventGoal> Goals { get; set; }
        public ICollection<EventPenalty> Penalty { get; set; }
        public Match() { }

        public Match(Team homeTeam, Team awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            DateTime = DateTime.Now;
            Place = "Poland";
        }
    }
}
