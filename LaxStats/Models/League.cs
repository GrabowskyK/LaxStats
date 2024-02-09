namespace LaxStats.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TeamsInLeague> Leagues { get; set; }
        public League() { }

        public League(string name) 
        { 
            Name = name;
        }
    }
}
