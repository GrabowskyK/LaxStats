namespace LaxStats.Models
{
    public class EventPenalty
    {
        public int Id { get; set; }
        public TimeSpan TimeEvent { get; set; } //when during the game
        public Player Player { get; set; } // who
        public PenaltyType PenaltyType { get; set; } //what type
        public int TimePenalty { get; set; } // 1minute, 2minute etc.
        public int MatchId { get; set; }
        public Match Match { get; set; }
    }

    public enum PenaltyType 
    { 
        Push,
        Crosscheck,
        Slashing,
        Tripping,
        Holding,
        IllegalBodyCheck,
        CreaseViolation,
        IllegalSubstitution,
        DelayingTheGame
    }
}
