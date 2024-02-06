using LaxStats.Models;

namespace LaxStats.Service.TeamServ
{
    public interface ITeamService
    {
        void AddTeam(Team team);
        public IEnumerable<Team> GetTeams();
    }
}
