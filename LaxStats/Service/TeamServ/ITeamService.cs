using LaxStats.Models;

namespace LaxStats.Service.TeamServ
{
    public interface ITeamService
    {
        void AddTeam(Team team);
        public IEnumerable<Team> GetTeams();




        //Do statycznego dodawania do bazy
        public void AddTeams(List<Team> teams);
        public void AddTeamsToLeague(List<TeamsInLeague> teams);
    }
}
