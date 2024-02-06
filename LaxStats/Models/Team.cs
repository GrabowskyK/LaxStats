namespace LaxStats.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<Player> Players { get; }

        public int win { get; set; }
        public int lose { get; set; }
        public int draw { get; set; }

        public ICollection<Match> HomeMatches { get; set; }
        public ICollection<Match> AwayMatches { get; set; }
    }
}
