namespace LaxStats.Models
{
    public class EventGoal
    {
        public int Id { get; set; }
        public TimeSpan TimeGoal { get; set; } //when during the game
        public Player Player { get; set; } // who
        public Player? Assist { get; set; }
        public int MatchId { get; set; }
        public Match Match {  get; set; }
    }
}
